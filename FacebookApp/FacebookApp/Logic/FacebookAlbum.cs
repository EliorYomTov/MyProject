using System;
using System.Data;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Net;
using System.IO;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using FacebookApp.Logic;

namespace FacebookApp.Logic
{
    public class FacebookAlbum
    {
        private DataTable m_AlbumsTable;
        private Album m_Album;

        public DataGridView PhotosDataGridView { get; set; }

        public FolderBrowserDialog FolderBrowserDialog { get; set; }

        public ProgressBar ProgressBar { get; set; }

        public Album Album
        {
            get
            {
                return m_Album;
            }

            set
            {
                m_Album = value;
            }
        }

        public DataTable AlbumsTable
        {
            get
            {
                return m_AlbumsTable;
            }

            set
            {
                m_AlbumsTable = value;
            }
        }

        public void CreateAlbumDataTable()
        {
            m_AlbumsTable = new DataTable();

            m_AlbumsTable.Columns.Add("Choose");
            m_AlbumsTable.Columns.Add("Picture");
            m_AlbumsTable.Columns.Add("Likes");
            m_AlbumsTable.Columns.Add("UploadDate");
            m_AlbumsTable.Columns.Add("Comments");
            m_AlbumsTable.Columns.Add("PhotoUrl");
            m_AlbumsTable.Columns[0].DataType = System.Type.GetType("System.Boolean");
            m_AlbumsTable.Columns[1].DataType = System.Type.GetType("System.Byte[]");
            m_AlbumsTable.Columns[2].DataType = System.Type.GetType("System.Int32");
            m_AlbumsTable.Columns[3].DataType = System.Type.GetType("System.String");
            m_AlbumsTable.Columns[4].DataType = System.Type.GetType("System.String");
            m_AlbumsTable.Columns[5].DataType = System.Type.GetType("System.String");
        }

        public void InsertDataIntoAlbumDataTable()
        {
            foreach (Photo photo in m_Album.Photos)
            {
                var imageConverter = new ImageConverter();
                object img = imageConverter.ConvertTo(photo.ImageNormal, System.Type.GetType("System.Byte[]"));
                m_AlbumsTable.Rows.Add(false, img, photo.LikedBy.Count.ToString(), photo.CreatedTime.ToString(), photo.Comments.Count.ToString(), photo.PictureNormalURL);
            }
        }

        public void ChangePhotosOrder(int i_ColumnNumber)
        {
            if (PhotosDataGridView.SortOrder == SortOrder.None)
            {
                PhotosDataGridView.Sort(PhotosDataGridView.Columns[i_ColumnNumber], System.ComponentModel.ListSortDirection.Descending);
            }
            else if (PhotosDataGridView.SortOrder == SortOrder.Descending)
            {
                PhotosDataGridView.Sort(PhotosDataGridView.Columns[i_ColumnNumber], System.ComponentModel.ListSortDirection.Ascending);
            }
            else if (PhotosDataGridView.SortOrder == SortOrder.Ascending)
            {
                PhotosDataGridView.Sort(PhotosDataGridView.Columns[i_ColumnNumber], System.ComponentModel.ListSortDirection.Descending);
            }
        }

        public void DownloadSelectedPhotos()
        {
            int randNum;
            string fileName;
            string path;

            DialogResult folderBrowserDialogResult = FolderBrowserDialog.ShowDialog();

            if (folderBrowserDialogResult == System.Windows.Forms.DialogResult.OK)
            {
                IAggregate dataGridRowsAggregate = new DataGridRowsAggregate(PhotosDataGridView);
                IIterator rowsDataGridIterator = dataGridRowsAggregate.CreateIterator();

                if (!rowsDataGridIterator.IsDone)
                {
                    using (WebClient Client = new WebClient())
                    {
                        Random rnd = new Random();

                        path = FolderBrowserDialog.SelectedPath;
                        ProgressBar.Maximum = 0;

                        foreach (DataGridViewRow row in rowsDataGridIterator.NextItem)
                        {
                            bool isSelected = Convert.ToBoolean(row.Cells[0].Value);

                            if (isSelected)
                            {
                                randNum = rnd.Next(1, 1000);
                                ProgressBar.Maximum++;
                                Uri uri = new Uri(row.Cells[5].Value.ToString());
                                fileName = randNum + ".gif";
                                Client.DownloadFile(uri, path + "\\" + fileName);
                                ProgressBar.Value++;
                                ProgressBar.Update();
                            }
                        }
                    }
                }

                ProgressBar.Maximum = 1;
                MessageBox.Show("Download Completed!");
            }

            ProgressBar.Value = 0;
        }
    }
}