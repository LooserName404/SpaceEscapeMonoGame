open Microsoft.Xna.Framework
open Microsoft.Xna.Framework.Graphics

type SpaceEscapeGame() as this =
    inherit Game()

    let _ = new GraphicsDeviceManager(this)

    let mutable spriteBatch = Unchecked.defaultof<_>

    override _.Initialize () =
        this.IsMouseVisible <- true

        base.Initialize()

    override _.LoadContent () =
        spriteBatch <- new SpriteBatch(this.GraphicsDevice)
        base.LoadContent()

    override _.Update gameTime =
        base.Update gameTime
    
    override _.Draw gameTime =
        this.GraphicsDevice.Clear Color.CornflowerBlue

        spriteBatch.Begin()

        spriteBatch.End()

        base.Draw gameTime

(new SpaceEscapeGame()).Run()
