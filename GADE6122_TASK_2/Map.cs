using System;
using System.Collections.Generic;
using System.Text;

namespace GADE6122_TASK_1
{
    class Map
    {
        public Tile[,] map;
        public Hero player;
        public Enemy[] enemies;
        public int Mapwidth;
        public int Mapheight;
        Random RNG = new Random();

        public Map(int maxHeight, int maxWidth, int minHeight, int minWidth, int numberOfEnemies)
        {
            Mapheight = RNG.Next(minHeight, maxHeight + 1);
            Mapwidth = RNG.Next(minWidth, maxWidth + 1);
            

            map = new Tile[Mapwidth + 2, Mapheight + 2];
            enemies = new Enemy[numberOfEnemies];

            var xMax = map.GetUpperBound(0);
            var yMax = map.GetUpperBound(1);

            for (int x = 0; x <= xMax; x++)
            {
                map[x, 0] = new Obstacle(x, 0);
                map[x, yMax] = new Obstacle(x, yMax);
            }

            for (int y = 0; y <= yMax; y++)
            {
                map[0, y] = new Obstacle(0, y);
                map[xMax, y] = new Obstacle(xMax, y);
            }
            player = Create(Tile.TILETYPE.hero) as Hero;
            for (int x = 0; x < enemies.Length; x++)
            {
                var enemy = Create(Tile.TILETYPE.enemy);

                enemies[x] = enemy as Enemy;
            }

            UpdateVision();
        }
        public void UpdateVision()
        {
            foreach (var tile in map)
            {
                if (tile != null && (tile.TileType == Tile.TILETYPE.hero || tile.TileType == Tile.TILETYPE.enemy))
                {
                    Character character = tile as Character;

                    character.Vision = new Tile[]
                    {
                        map[character.X, character.Y - 1],
                        map[character.X, character.Y + 1],
                        map[character.X + 1, character.Y],
                        map[character.X - 1, character.Y]
                    };

                    map[character.X, character.Y] = character;
                }
            }
        }

        private Tile Create(Tile.TILETYPE tileType)
        {
            Tile tile = null;

            while (1 == 1)
            {
                int rand1 = RNG.Next(1, Mapwidth);
                int rand2 = RNG.Next(1, Mapheight);

                if (map[rand1, rand2] == null)
                {
                    switch (tileType)
                    {
                        case Tile.TILETYPE.hero:
                            tile = new Hero(rand1, rand2, 100);
                            break;
                        case Tile.TILETYPE.enemy:
                            tile = new Goblin(rand1, rand2);
                            break;
                    }

                    map[rand1, rand2] = tile;

                    break;
                }
            }

            return tile;
        }




    }
}
