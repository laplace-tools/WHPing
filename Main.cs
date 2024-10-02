using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WHPing
{
    public partial class Main : Form
    {
        private bool isCheckServerStatus = false;
        private int errorCount = 0;
        private string host = string.Empty;
        private string webhookDisplayName = "サーバー監視 通知システム";

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.Timer.Enabled = false;
            this.CycleComboBox.SelectedIndex = 0;
            this.StatusTextBox.Text = "停止中";
            this.VersionLabel.Text = "Ver."+System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).FileVersion;
        }

        private void WebhookTestButton_Click(object sender, EventArgs e)
        {
            string webhook_url = Properties.Settings.Default.webhook_url;
            HttpClient httpClient = new HttpClient();
            PostParameter postParameter = new PostParameter()
            {
                content = "webhook send OK!",
                displayName = "webhook test",
            };

            var ret = httpClient.PostAsync(webhook_url, postParameter.encodedContent());
            //httpClient.Dispose();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            // UIコントロール
            this.StartButton.Enabled = false;
            this.StopButton.Enabled = true;
            this.Ipv4.Enabled = false;
            this.CycleComboBox.Enabled = false;
            this.WebhookTestButton.Enabled = false;
            this.PingTestButton.Enabled = false;
            this.PingTestLabel.Text = "";
            // 変数セット
            this.isCheckServerStatus = true;
            this.host = this.Ipv4.Text;
            this.errorCount = 0;
            // タイマーセット
            switch (this.CycleComboBox.SelectedItem)
            {
                case "1分"   : this.Timer.Interval = 1000 * 60; break;
                case "10分"  : this.Timer.Interval = 1000 * 60 * 10; break;
                case "60分"  : this.Timer.Interval = 1000 * 60 * 60; break;
                case "24時間": this.Timer.Interval = 1000 * 60 * 60 * 24; break;
            }
            this.Timer.Enabled = true;
            // ステータス表示変更
            this.StatusTextBox.Text = "開始中";
            this.StopButton.Focus();
            // 開始時初回動作
            this.Refresh();
            this.CheckMain();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            // UIコントロール
            this.StopButton.Enabled = false;
            this.StartButton.Enabled = true;
            this.Ipv4.Enabled = true;
            this.CycleComboBox.Enabled = true;
            this.WebhookTestButton.Enabled = true;
            this.PingTestButton.Enabled = true;
            // 変数セット
            isCheckServerStatus = false;
            // タイマーアンセット
            this.Timer.Enabled = false;
            // ステータス表示変更
            this.StatusTextBox.Text = "停止";
            this.StartButton.Focus();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // メイン処理
            this.CheckMain();
        }

        private void PingTestButton_Click(object sender, EventArgs e)
        {
            this.PingTestLabel.Text = "";
            bool ping_ret = HostCheck.PingTarget(this.Ipv4.Text);
            if (ping_ret)
            {
                this.PingTestLabel.Text = "OK";
            }
            else {
                this.PingTestLabel.Text = "NG";
            }
        }

        private void CheckMain()
        {
            if (isCheckServerStatus)
            {
                bool ping_ret = HostCheck.PingTarget(this.host);
                if (!ping_ret)
                {
                    //10秒待ってから2回目
                    Thread.Sleep(1000 * 10);
                    ping_ret = HostCheck.PingTarget(this.host);
                    if (!ping_ret)
                    {
                        //エラーカウント増加
                        this.errorCount++;
                        //Discodeへの通知処理
                        string now = DateTime.Now.ToString();
                        string webhook_url = Properties.Settings.Default.webhook_url;
                        HttpClient httpClient = new HttpClient();
                        PostParameter postParameter = new PostParameter()
                        {
                            content = "【第" + this.errorCount.ToString() + "報】\nPingでの疎通確認に失敗しました。対象のサーバーを確認して下さい。\r対象サーバー : " + host + "\r疎通確認日時 : " + now,
                            displayName = this.webhookDisplayName,
                        };
                        this.StatusTextBox.Text = "監視中：NG";

                        var ret = httpClient.PostAsync(webhook_url, postParameter.encodedContent());
                    }
                    else
                    {
                        this.StatusTextBox.Text = "監視中：OK";
                        //復旧を通知
                        if (this.errorCount != 0)
                        {
                            //Discodeへの通知処理
                            string now = DateTime.Now.ToString();
                            string webhook_url = Properties.Settings.Default.webhook_url;
                            HttpClient httpClient = new HttpClient();
                            PostParameter postParameter = new PostParameter()
                            {
                                content = "【復旧報】\nPingでの疎通確認に成功しました。対象のサーバーは復旧しました。\r対象サーバー : " + host + "\r疎通確認日時 : " + now,
                                displayName = this.webhookDisplayName,
                            };
                            var ret = httpClient.PostAsync(webhook_url, postParameter.encodedContent());
                        }
                        this.errorCount = 0;
                    }
                }
                else
                {
                    this.StatusTextBox.Text = "監視中：OK";
                    //復旧を通知
                    if (this.errorCount != 0)
                    {
                        //Discodeへの通知処理
                        string now = DateTime.Now.ToString();
                        string webhook_url = Properties.Settings.Default.webhook_url;
                        HttpClient httpClient = new HttpClient();
                        PostParameter postParameter = new PostParameter()
                        {
                            content = "【復旧報】\nPingでの疎通確認に成功しました。対象のサーバーは復旧しました。\r対象サーバー : " + host + "\r疎通確認日時 : " + now,
                            displayName = this.webhookDisplayName,
                        };
                        var ret = httpClient.PostAsync(webhook_url, postParameter.encodedContent());
                    }
                    this.errorCount = 0;
                }
            }
        }
    }
}
