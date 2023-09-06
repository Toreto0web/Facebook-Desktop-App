﻿using System.IO;
using FacebookWrapper.ObjectModel;
using System.Net;

namespace FacebookDAppLogics
{
    public class AlbumAdapter
    {
        public Album Album { get; set; }

        public string FolderPath { get; set; }

        private byte photoIndex = 0;

        public void DownloadSelectedAlbum() 
        {
            foreach (Photo photo in Album.Photos)
            {
                string imageUrl = photo.PictureNormalURL;
                string fileName = (++photoIndex).ToString() + ".jpg";
                string fullPath = Path.Combine(FolderPath, fileName);

                using (WebClient webClient = new WebClient())
                {
                    byte[] imageBytes = webClient.DownloadData(imageUrl);

                    File.WriteAllBytes(fullPath, imageBytes);
                }
            }
        }
    }
}
