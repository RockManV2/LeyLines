using System.Drawing;
using LeyLines.SceneManagement;
using OpenTK.Graphics.OpenGL4;
using OpenTK.Mathematics;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;

namespace LayLines;


public class Application : GameWindow
{
    #region Constructors

    public Application() : base(GameWindowSettings.Default, NativeWindowSettings.Default)
    {
        
    }

    #endregion

    #region LifeTime Methods

    protected override void OnResize(ResizeEventArgs args)
    {
        CenterWindow(new Vector2i(1920, 1020));
        GL.ClearColor(Color.CornflowerBlue);
        GL.Viewport(0,0, args.Width, args.Height);
        
        base.OnResize(args);
    }

    protected override void OnLoad()
    {
        SceneManager.ActiveScene.Awake();
        SceneManager.ActiveScene.Start();
        
        
        base.OnLoad();
    }

    protected override void OnUnload()
    {
        
        
        base.OnUnload();
    }

    protected override void OnUpdateFrame(FrameEventArgs args)
    {
        SceneManager.ActiveScene.Update();
        
        base.OnUpdateFrame(args);
    }
    
    protected override void OnRenderFrame(FrameEventArgs args)
    {
        SceneManager.ActiveScene.Draw();
        GL.Clear(ClearBufferMask.ColorBufferBit);

        this.Context.SwapBuffers();
        base.OnRenderFrame(args);
    }

    #endregion
    
}