//using OpenTK.Graphics.ES20;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace laba_2
{
    class View
    {
        Bitmap textureImage;
        int VBOtexture;
        public void Load2DTexture()
        {
            GL.BindTexture(TextureTarget.Texture2D, VBOtexture);
            BitmapData data = textureImage.LockBits(
                new System.Drawing.Rectangle(0, 0, textureImage.Width, textureImage.Height),
                ImageLockMode.ReadOnly,
                System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgba, data.Width, data.Height, 0, OpenTK.Graphics.OpenGL.PixelFormat.Bgra,
                PixelType.UnsignedByte, data.Scan0);
            textureImage.UnlockBits(data);

            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Linear);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)TextureMagFilter.Linear);

            ErrorCode Er = GL.GetError();
            string str = Er.ToString();
        }
        public void generateTextureImage(int layerNumber)
        {
            textureImage = new Bitmap(Bin.X, Bin.Y);
            for( int i = 0; i < Bin.X; i++)
            {
                for(int j = 0; j < Bin.Y; j++)
                {
                    int pixelNumber = i + j * Bin.X + layerNumber * Bin.X * Bin.Y;
                    textureImage.SetPixel(i, j, Transferfunction(Bin.array[pixelNumber]));
                }
            }
        }
        public void DrawTexture()
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.Enable(EnableCap.Texture2D);
            GL.BindTexture(TextureTarget.Texture2D, VBOtexture);

            GL.Begin(BeginMode.Quads);
            GL.Color3(Color.White);
            GL.TexCoord2(0f, 0f);
            GL.Vertex2(0, 0);
            GL.TexCoord2(0f, 1f);
            GL.Vertex2(0, Bin.Y);
            GL.TexCoord2(1f, 1f);
            GL.Vertex2(Bin.X, Bin.Y);
            GL.TexCoord2(1f, 0f);
            GL.Vertex2(Bin.X, 0);
            GL.End();

            GL.Disable(EnableCap.Texture2D);
        }



        int Clamp(int val, short min,short max)
        {
            if (val > max)
                return max;
            else if (val < min) return min;
            return val;
        }
        public int TF_min = 0;
        public int TF_width = 255;
        Color Transferfunction(short value)
        {
            int min = TF_min, max = TF_min+TF_width;
            int newVal = Clamp((value - min) * 255 / (max - min), 0, 255);
            return Color.FromArgb(255,newVal,newVal,newVal);
        }

        public void SetupView(int width, int height)
        {
            GL.ShadeModel(ShadingModel.Smooth);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(0, Bin.X, 0, Bin.Y, -1, 1);
            GL.Viewport(0, 0, width, height);
        }

        public void DrawQuads(int layerNumber)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.Begin(BeginMode.Quads);
            for(int x_coord = 0;x_coord<Bin.X - 1; x_coord++)
                for(int y_coord = 0;y_coord<Bin.Y - 1; y_coord++)
                {
                    short value;
                    //1 вершина
                    value = Bin.array[x_coord + y_coord * Bin.X + layerNumber * Bin.X * Bin.Y];
                    GL.Color3(Transferfunction(value));
                    GL.Vertex2(x_coord, y_coord);
                    //2 вершина
                    value = Bin.array[x_coord + (y_coord+1) * Bin.X + layerNumber * Bin.X * Bin.Y];
                    GL.Color3(Transferfunction(value));
                    GL.Vertex2(x_coord, y_coord+1);
                    //3 вершина
                    value = Bin.array[(x_coord+1) + (y_coord + 1) * Bin.X + layerNumber * Bin.X * Bin.Y];
                    GL.Color3(Transferfunction(value));
                    GL.Vertex2(x_coord+1, y_coord+1);
                    //4 вершина
                    value = Bin.array[(x_coord + 1) + (y_coord) * Bin.X + layerNumber * Bin.X * Bin.Y];
                    GL.Color3(Transferfunction(value));
                    GL.Vertex2(x_coord + 1, y_coord);
                }
            GL.End();
        }
        public void DrawQuadStrip(int layerNumber)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.Begin(BeginMode.QuadStrip);
            short value;

            //1 вершина
            value = Bin.array[0 + 0 * Bin.X + layerNumber * Bin.X * Bin.Y];
            GL.Color3(Transferfunction(value));
            GL.Vertex2(0, 0);
            //2 вершина
            value = Bin.array[0 + (0 + 1) * Bin.X + layerNumber * Bin.X * Bin.Y];
            GL.Color3(Transferfunction(value));
            GL.Vertex2(0, 0 + 1);
            //3 вершина
            value = Bin.array[(0 + 1) + (0 + 1) * Bin.X + layerNumber * Bin.X * Bin.Y];
            GL.Color3(Transferfunction(value));
            GL.Vertex2(0 + 1, 0 + 1);
            //4 вершина
            value = Bin.array[(0 + 1) + (0) * Bin.X + layerNumber * Bin.X * Bin.Y];
            GL.Color3(Transferfunction(value));
            GL.Vertex2(0 + 1, 0);

            int x_coord = 2;
            int y_coord = 0;
            int step = 1;

            while(y_coord < Bin.Y-1)
            {
                if (x_coord == Bin.X || x_coord == -1)
                {
                    step *= -1;

                    int tmp = x_coord + (y_coord + 1) * Bin.X + layerNumber * Bin.X * Bin.Y;
                    value = Bin.array[x_coord + (y_coord + 1) * Bin.X + layerNumber * Bin.X * Bin.Y];
                    GL.Color3(Transferfunction(value));
                    GL.Vertex2(x_coord, y_coord + 1);
                    value = Bin.array[x_coord + step + (y_coord + 1) * Bin.X + layerNumber * Bin.X * Bin.Y];
                    GL.Color3(Transferfunction(value));
                    GL.Vertex2(x_coord, y_coord);
                    y_coord++;
                    x_coord += step;

                    continue;
                }

                value = Bin.array[x_coord + y_coord * Bin.X + layerNumber * Bin.X * Bin.Y];
                GL.Color3(Transferfunction(value));
                GL.Vertex2(x_coord, y_coord);
                value = Bin.array[x_coord + (y_coord + 1) * Bin.X + layerNumber * Bin.X * Bin.Y];
                GL.Color3(Transferfunction(value));
                GL.Vertex2(x_coord, y_coord + 1);

                x_coord += step;

            }

            GL.End();
        }
    }
}
