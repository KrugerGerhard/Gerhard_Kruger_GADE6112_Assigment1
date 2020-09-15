using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Question 3.1 & 3.2
namespace Gerhard_Kruger_19343413_GADE6112_Assigment1_GoblinSlayer
{
     class MapClass
    {
        //Variable and Class declaration
        private TileClass[,] mapTiles;
        private HeroClass hero;
        private EnemyClass[] enemies;
        private int mapWidth, mapHeight;
        private Random rnd = new Random();

        public MapClass(int minWidth, int maxWidth, int minHeight, int maxHeight, int numOfEnemies)
        {
            //Random gen for map height and width
            mapWidth = rnd.Next(minWidth, maxWidth + 1);
            mapHeight = rnd.Next(minHeight, maxHeight + 1);

            //Base map creation and tile placement
            GenerateEmptyTiles();

            ////Creates hero and enemy tiles on the map
            hero = (HeroClass)Create(TileClass.TileType.Hero);
            mapTiles[hero.X, hero.Y] = hero;
            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i] = (EnemyClass)Create(TileClass.TileType.Enemy);
                mapTiles[enemies[i].X, enemies[i].Y] = enemies[i];
            }
        }

        public int MapWidth
        {
            get { return mapWidth; }
            private set { mapWidth = value; }
        }

        public int MapHeight
        {
            get { return mapHeight; }
            private set { mapHeight = value; }
        }

        public TileClass[,] MapTiles
        {
            get { return mapTiles; }
            set { mapTiles = value; }
        }

        public HeroClass Hero
        {
            get { return hero; }
            set { hero = value; }
        }

        public EnemyClass[] Enemies
        {
            get { return enemies; }
            set { enemies = value; }
        }

        //Tile Creation Method
        private TileClass Create(TileClass.TileType type)
        {
            int x = rnd.Next(0, mapWidth);
            int y = rnd.Next(0, mapHeight);
            while (!(mapTiles[x, y].GetType().Name.Equals(nameof(EmptyTileClass))))
            {
                x = rnd.Next(0, mapWidth);
                y = rnd.Next(0, mapHeight);
            }

            TileClass createdTile = null;

            switch (type)
            {
                case TileClass.TileType.Hero:
                    createdTile = new HeroClass(x, y, 10, 2);
                    break;
                case TileClass.TileType.Enemy:
                    createdTile = new GoblinClass(x, y);
                    break;
            }

            return createdTile;
        }

        //Empty tile generation method for enterable tiles
        public void GenerateEmptyTiles()
        {
            for (int i = 0; i < mapWidth; i++)
            {
                for (int j = 0; j < mapHeight; j++)
                {
                    mapTiles[i, j] = new EmptyTileClass(i, j);
                }
            }
        }

    }
}