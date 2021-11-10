using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace GADE6122_TASK_2
{
    class GameEngine
    {
        private BinaryFormatter formatter;

        private const string DATA_FILENAME = "GADE6122_SAVE.bin";
        public Map newMap;
        public GameEngine()
        {
            newMap = new Map(15,15,10,10,10,10);
            
        }
        public void MovePlayer(Character.MOVEMENT direction)
        {
            var validMove = newMap.player.ReturnMove(direction);

            if (newMap.player.ReturnMove(direction) != Character.MOVEMENT.noMovement)
            {
                newMap.map[newMap.player.X, newMap.player.Y] = null;

                switch (direction)
                {
                    case Character.MOVEMENT.Up:
                        newMap.player.X -= 1;
                        break;
                    case Character.MOVEMENT.Down:
                        newMap.player.Y += 1;
                        break;
                    case Character.MOVEMENT.Right:
                        newMap.player.X += 1;
                        break;
                    case Character.MOVEMENT.Left:
                        newMap.player.X -= 1;
                        break;
                }

                newMap.map[newMap.player.X, newMap.player.Y] = newMap.player;
            }
        }
        public string BuildMap()
        {
            var mapString = new StringBuilder();

            for (int y = 0; y <= newMap.map.GetUpperBound(1); y++)
            {
                for (int x = 0; x <= newMap.map.GetUpperBound(0); x++)
                {
                    mapString.Append($"{GetSymbol(newMap.map[x, y]?.TileType)}\t");
                }
                mapString.AppendLine();
            }

            return mapString.ToString();
        }

        private char GetSymbol(Tile.TILETYPE? tileType)
        {
            switch (tileType)
            {
                case Tile.TILETYPE.hero:
                    return 'H';
                case Tile.TILETYPE.goblin:
                    return 'G';
                case Tile.TILETYPE.mage:
                    return 'M';
                case Tile.TILETYPE.obstacle:
                    return 'X';
                default:
                    return '.';
            }
        }
        public bool EnemyAttacks()
        {
            if(Character.MOVEMENT = true)
            {
                return true;
            }
            if(Enemy.MOVEMENT = true)
            { 
                 return true;
            }
        }
        public void MoveEnemies(MOVEMENT mOVEMENT)
        {
            switch (mOVEMENT)
            {
                case MOVEMENT.Up: y = y + 1; break;
                case MOVEMENT.Down: y = y - 1; break;
                case MOVEMENT.Right: x = x + 1; break;
                case MOVEMENT.Left: x = x - 1; break;
            }
        }
        public void Save()
        {
            try
            {
                FileStream writerFileStream =
                    new FileStream(DATA_FILENAME, FileMode.Create, FileAccess.Write);

                this.BuildMap.Serialize(writerFileStream, this.BuildMap);


                writerFileStream.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to save the current map");
            } 
        } 

        public void Load()
        {


            if (File.Exists(DATA_FILENAME))
            {

                try
                {
                    FileStream readerFileStream = new FileStream(DATA_FILENAME,
                        FileMode.Open, FileAccess.Read);
                    this.BuildMap = (Dictionary<String, GADE6122_TASK_2>)
                        this.formatter.Deserialize(readerFileStream);
                    readerFileStream.Close();

                }
                catch (Exception)
                {
                    Console.WriteLine("The saved file containing the map cannot be read.");
                } 

            } 

        } 
    }
}
