open Microsoft.Xna.Framework
open Microsoft.Xna.Framework.Graphics
open Garnet.Composition
open SpaceEscape.Core.Commands
open SpaceEscape.Core.Systems

type SpaceEscapeGame() as this =
    inherit Game()

    let _ = new GraphicsDeviceManager(this)

    let mutable spriteBatch = Unchecked.defaultof<_>

    let world = Container()

    override _.Initialize () =
        this.IsMouseVisible <- true

        base.Initialize()

    override _.LoadContent () =
        spriteBatch <- new SpriteBatch(this.GraphicsDevice)

        Disposable.Create [
            registerDraw world
        ] |> ignore

        base.LoadContent()

    override _.Update gameTime =
        base.Update gameTime
    
    override _.Draw gameTime =
        this.GraphicsDevice.Clear Color.CornflowerBlue

        spriteBatch.Begin()

        world.Run { SpriteBatch = spriteBatch }

        spriteBatch.End()

        base.Draw gameTime

(new SpaceEscapeGame()).Run()
