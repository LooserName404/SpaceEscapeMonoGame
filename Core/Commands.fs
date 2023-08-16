module SpaceEscape.Core.Commands

open Microsoft.Xna.Framework.Graphics

[<Struct>]
type DrawCmd = {
    SpriteBatch: SpriteBatch
}
