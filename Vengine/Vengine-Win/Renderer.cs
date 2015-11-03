using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vengine_Win
{
    enum RendererTypes
    {
        OpenGL, DirectX
    }
    interface IRenderer
    {
        
    }
    class Renderer : IRenderer
    {

        public Renderer GetRenderer(RendererTypes r)
        {
            if (r == RendererTypes.DirectX)
            {
                return new DirectXRenderer();
            }
            else if (r == RendererTypes.OpenGL)
            {
                return new OpenGLRenderer();
            }
            return new Renderer();
        }
    }
    class OpenGLRenderer : Renderer,IRenderer
    {

    }           
    class DirectXRenderer : Renderer,IRenderer
    {

    }
}
