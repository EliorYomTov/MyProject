using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookApp.Logic
{
    public class OrderAlbumsByPhotosCountDEC : OrderDefiner
    {
        public override bool IsNeedSwap(object i_Album1, object i_Album2)
        {
            Album album1 = i_Album1 as Album;
            Album album2 = i_Album2 as Album;
            return album1.Photos.Count < album2.Photos.Count;
        }

        public override string ToString()
        {
            return "Descending photos count ";
        }
    }
}