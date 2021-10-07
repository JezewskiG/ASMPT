using System.Drawing;

namespace Renderer
{
    class Renderer {

        public Renderer(int width, int height) {
            imageWidth = width;
            imageHeight = height;
            camera = new Camera(width, height);
        }

        public void renderImage(int sampleCount, Bitmap bmp) {
            
            for (int y = 0; y < imageHeight; y++) {
                for (int x = 0; x < imageWidth; x++) {

                    float pixelW = x / (imageWidth-1);
                    float pixelH = y / (imageHeight-1);

                    var pixelRay = camera.makeRay(pixelW, pixelH);

                    int R = (int)(255 * pixelW);
                    int G = (int)(255 * pixelH);
                    int B = (int)(0.5f * 255);
                    
                    Color outColor = Color.FromArgb(R, G, B);

                    bmp.SetPixel(x, y, outColor);

                }
            }

         }

        private Camera camera;
        private int imageWidth;
        private int imageHeight;
    }

}
