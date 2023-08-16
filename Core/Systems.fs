module SpaceEscape.Core.Systems

open SpaceEscape.Core.Commands
open SpaceEscape.Core.Components
open Garnet.Composition

let registerDraw (container: Container) =
    container.On<DrawCmd> (
        fun (cmd: DrawCmd) struct ((Position position), (DrawingProperties properties)) ->
            let spriteBatch = cmd.SpriteBatch

            spriteBatch.Draw(
                texture = properties.Texture,
                position = position,
                sourceRectangle = properties.SourceRectangle,
                color = properties.Color,
                rotation = properties.Rotation,
                origin = properties.Origin,
                scale = properties.Scale,
                effects = properties.Effect,
                layerDepth = properties.LayerDepth
            )
        |> Join.iter2
        |> Join.over container
    )
