# Multiplayer_Game

In this game we added player animation and a shield.

Itch.io: https://amitay2022.itch.io/multiplayer-game

## Scripts:

### [PlayerManager](https://github.com/Game-Project-Itay-Amit/Multiplayer_Game/blob/main/Assets/scripts/Player/PlayerManager.cs):

Added is Start(), OnTriggerStay() and in OnTriggerEnter() handeling of the shield. In Start() we caught the shield prefab and the message shown to the player once the shield is picked up.
In OnTriggerEnter() and in OnTriggerStay() changed that only a player without a shield can get hurt by lasers.

### [PlayerMover](https://github.com/Game-Project-Itay-Amit/Multiplayer_Game/blob/main/Assets/scripts/Player/PlayerMover.cs):

Changed the script so that it would handle animation as well as player movement.

### [ShieldManager](https://github.com/Game-Project-Itay-Amit/Multiplayer_Game/blob/main/Assets/scripts/Shield/ShieldManager.cs):

Removes the shield when it is picked up by another player across all players.

### [ShieldMover](https://github.com/Game-Project-Itay-Amit/Multiplayer_Game/blob/main/Assets/scripts/Shield/ShieldMover.cs):

Rotates the shield to draw attention to it.
