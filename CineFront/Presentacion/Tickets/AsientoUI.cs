using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineFront.Presentacion.PruebaAsientos
{
    internal static class AsientoUI
    {
        public static Image GetDefaultImage()
        {
            return Properties.Resources.armchair_unselected;
        } 
        public static Image GetSelectedImage()
        {
            return Properties.Resources.armchair_selected;
        } 
        public static Image GetOcuppedImage()
        {
            return Properties.Resources.armchair_ocupped;
        } 

        public static string getLetter(int i)
        {
            List<string> list = new List<string>();
            list.Add("A");
            list.Add("B");
            list.Add("C");
            list.Add("E");
            list.Add("F");
            list.Add("G");
            list.Add("H");
            list.Add("I");
            return list[i];
        }
    }
}
