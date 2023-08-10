open Microsoft.Xna.Framework

type SpaceEscapeGame() as this =
    inherit Game()

    let graphics = new GraphicsDeviceManager(this)

    override this.Initialize () =
        this.IsMouseVisible <- true

        base.Initialize()

    override _.LoadContent () =
        base.LoadContent()

    override _.Update gameTime =
        base.Update gameTime
    
    override this.Draw gameTime =
        this.GraphicsDevice.Clear Color.CornflowerBlue

        base.Draw gameTime

(new SpaceEscapeGame()).Run()
