using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_questions
{
    public class mobile
    {
        public string s = "Android";
        public void camera()
        {
            Console.WriteLine("camera feature " + this.s);
        }
    }

    public static class mobile_extension
    {
        public static void camerafilter(this mobile mb)
        {
            Console.WriteLine("camera filter");
        }
        public static void HDR(this mobile mb, bool f)
        {
            Console.WriteLine("HDR filter " + f);
        }
    }
    class extensionmethod
    {
        static void Main(string[] args)
        {
            mobile obj = new mobile();
            obj.camera();
            // calling extension methods
            obj.camerafilter();
            obj.HDR(true);
            Console.ReadLine();
        }
    }
}
