using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System;
using System.Threading;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using YoutubeExtractor;

namespace FacebookApp.Logic
{
    public class VideoStreamer
    {
        private string m_UrlVideoFromPost;

        public WebBrowser WebBrowserForVideos { get; set; }

        public ProgressBar VideoDownloadProgressBar { get; set; }

        public FolderBrowserDialog FolderBrowserDialog { get; set; }

        public Button DownloadVideoButton { get; set; }

        public void GetSelectedPostVideoUrl(Post i_SelectedPost)
        {
            if (i_SelectedPost != null)
            {
                m_UrlVideoFromPost = i_SelectedPost.Link;
            }
        }

        public void ShowVideosInBrowser()
        {
            WebBrowserForVideos.Navigate(m_UrlVideoFromPost);
        }

        public void DownloadSelectedVideo()
        {
            VideoDownloadProgressBar.Minimum = 0;
            VideoDownloadProgressBar.Maximum = 100;

            DialogResult folderBrowserDialogResult = FolderBrowserDialog.ShowDialog();
            if (folderBrowserDialogResult == System.Windows.Forms.DialogResult.OK)
            {
                IEnumerable<VideoInfo> videos = DownloadUrlResolver.GetDownloadUrls(m_UrlVideoFromPost);
                VideoInfo video = videos.First(p => p.VideoType == VideoType.Mp4);
                if (video.RequiresDecryption)
                {
                    DownloadUrlResolver.DecryptDownloadUrl(video);
                }

                string path = FolderBrowserDialog.SelectedPath;
                string cleanString = System.Text.RegularExpressions.Regex.Replace(video.Title, @"[^a-zA-Z 0-9'.@]", string.Empty).Trim();
                VideoDownloader downloader = new VideoDownloader(video, Path.Combine(path + "\\", cleanString + video.VideoExtension));
                downloader.DownloadProgressChanged += downloader_DownloadVideoProgressBarChanged;
                downloader.DownloadFinished += downloader_DownloadVideoFinished;
                Thread thread = new Thread(() => { downloader.Execute(); }) { IsBackground = true };
                thread.Start();
            }
            else
            {
                DownloadVideoButton.Enabled = true;
            }
        }

        private void downloader_DownloadVideoProgressBarChanged(object sender, ProgressEventArgs e)
        {
            VideoDownloadProgressBar.Invoke(new Action(delegate()
            {
                VideoDownloadProgressBar.Maximum++;
                VideoDownloadProgressBar.Value++;
                VideoDownloadProgressBar.Update();
            }));
        }

        private void downloader_DownloadVideoFinished(object sender, EventArgs e)
        {
            VideoDownloadProgressBar.Invoke(new Action(delegate()
            {
                VideoDownloadProgressBar.Maximum = 0;
                VideoDownloadProgressBar.Value = 0;
                VideoDownloadProgressBar.Update();
                MessageBox.Show("Download Completed");
                DownloadVideoButton.Enabled = true;
            }));
        }
    }
}
