module SpaceEscape.Core.Components

open System
open Microsoft.Xna.Framework
open Microsoft.Xna.Framework.Graphics

[<Struct>] type Position = Position of Vector2

[<Struct>]
type DrawingProperties = DrawingProperties of {|
    Texture: Texture2D
    SourceRectangle: Nullable<Rectangle>
    Color: Color
    Rotation: Single
    Origin: Vector2
    Scale: Vector2
    Effect: SpriteEffects
    LayerDepth: Single
|}
with
    static member Simple texture =
        DrawingProperties {|
            Texture = texture
            SourceRectangle = Nullable<Rectangle>()
            Color = Color.White
            Rotation = 0f
            Origin = Vector2.Zero
            Scale = Vector2.One
            Effect = SpriteEffects.None
            LayerDepth = 0f
        |}

