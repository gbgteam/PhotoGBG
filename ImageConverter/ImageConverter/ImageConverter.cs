using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace ImageConverter
{
    class ImageConverter
    {
        private void VaryQualityLevel()
        {
                Bitmap bmp1 = new Bitmap(@"d:\image.bmp");
                ImageCodecInfo jgpEncoder = GetEncoder(ImageFormat.Jpeg);

                
                System.Drawing.Imaging.Encoder myEncoder =
                    System.Drawing.Imaging.Encoder.Quality;

                
                EncoderParameters myEncoderParameters = new EncoderParameters(1);

                EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder,50L);
                myEncoderParameters.Param[0] = myEncoderParameter;
                bmp1.Save(@"d:\TestPhotoQualityFifty.jpg", jgpEncoder,myEncoderParameters);

                //myEncoderParameter = new EncoderParameter(myEncoder, 100L);
                //myEncoderParameters.Param[0] = myEncoderParameter;
                //bmp1.Save(@"d:\TestPhotoQualityHundred.jpg", jgpEncoder,myEncoderParameters);

                //myEncoderParameter = new EncoderParameter(myEncoder, 0L);
                //myEncoderParameters.Param[0] = myEncoderParameter;
                //bmp1.Save(@"d:\TestPhotoQualityZero.jpg", jgpEncoder,
                //    myEncoderParameters);
        }


        private ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();

            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }

        static void Main()
        {
            ImageConverter ic = new ImageConverter();
            ic.VaryQualityLevel();
        }
        
    }
}

