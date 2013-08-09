using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using Jackie_s_RPGLIB.Database.Tile_Engine;
using Jackie_s_RPGLIB.Database.Character;
using Jackie_s_RPGLIB.Graphic;
using Jackie_s_RPGLIB.Database.Functional;
using Jackie_s_RPGLIB.Database.Functional.Map;

namespace Jackie_s_RPGLIB.Database.Core
{
    public class IO
    {
        #region Field

        BinaryReader br; // dem binary
        BinaryWriter bw;

        #endregion Field

        #region Constructor

        public IO()
        {
        }

        #endregion Constructor

        #region Method

        public void SaveEvent(Event e)
        {
            bw.Write(e.Type);

            switch (e.Type)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    Warp w = e as Warp;
                    bw.Write(w.WarpMap);
                    bw.Write(w.WarpX);
                    bw.Write(w.WarpY);
                    bw.Write(w.Position);
                    break;

                case 3: //Conditioner Location
                    ConditionerLoc cl = e as ConditionerLoc;
                    bw.Write(cl.ReqMap);
                    bw.Write(cl.ReqX);
                    bw.Write(cl.ReqY);
                    bw.Write(cl.Position);

                    bw.Write(cl.If.Count);
                    foreach (Event miniE in cl.If)
                        SaveEvent(miniE);

                    bw.Write(cl.Else.Count);
                    foreach (Event miniE in cl.Else)
                        SaveEvent(miniE);
                    break;

                case 4:
                    ConditionerVariable cv = e as ConditionerVariable;
                    bw.Write(cv.ReqVariable);
                    bw.Write(cv.ReqValue);

                    bw.Write(cv.If.Count);
                    foreach (Event miniE in cv.If)
                        SaveEvent(miniE);

                    bw.Write(cv.Else.Count);
                    foreach (Event miniE in cv.Else)
                        SaveEvent(miniE);

                    break;
                case 5:

                    ConditionerSwitch cs = e as ConditionerSwitch;
                    bw.Write(cs.ReqSwitch);
                    bw.Write(cs.ReqValue);

                    bw.Write(cs.If.Count);
                    foreach (Event miniE in cs.If)
                        SaveEvent(miniE);

                    bw.Write(cs.Else.Count);
                    foreach (Event miniE in cs.Else)
                        SaveEvent(miniE);

                    break;

                case 6:
                    SetSwitch ss = e as SetSwitch;
                    bw.Write(ss.Switch);
                    bw.Write(ss.Value);
                    bw.Write(ss.ChangeType);

                    break;
                case 7:
                    SetVariable sv = e as SetVariable;
                    bw.Write(sv.Variable);
                    bw.Write(sv.Value);
                    bw.Write(sv.ChangeType);

                    break;
            }
        }

        public void SaveProject(Game obj) // Save the game yo. This should not be used in the actual game, as the title said "PROJECT". Use in a game engine
        {
            using (bw = new BinaryWriter(File.Open(obj.Path + "\\Game.jrpg", FileMode.Create)))
            {
                bw.Write(obj.Name);
                bw.Write(obj.Path);
                bw.Write(obj.Author);
                bw.Write(obj.Description);
                bw.Write(obj.SubName);
                bw.Write(obj.TileX);
                bw.Write(obj.TileY);
                bw.Write(obj.StartMap);
                bw.Write(obj.StartX);
                bw.Write(obj.StartY);

                bw.Write(obj.MySwitch.Count);
                for (int i = 0; i < obj.MySwitch.Count; i++)
                    bw.Write(obj.MySwitch[i].Name);

                bw.Write(obj.MyVariable.Count);
                for (int i = 0; i < obj.MyVariable.Count; i++)
                    bw.Write(obj.MyVariable[i].Name);

                //Inital Party
                bw.Write(obj.InitialParty.Count);
                for (int i = 0; i < obj.InitialParty.Count; i++)
                {
                    bw.Write(obj.InitialParty[i]);
                }

                //Please keep all the non engine related stuff up here

                // From this point onward is all engine related stuff

                // Tile Engine
                bw.Write(obj.TM.myTileset.Count);
                for (int i = 0; i < obj.TM.myTileset.Count; i++)
                {
                    bw.Write(obj.TM.myTileset[i].Name);
                    bw.Write(obj.TM.myTileset[i].ID);
                }

                bw.Write(obj.TM.myMap.Count);
                for (int i = 0; i < obj.TM.myMap.Count; i++)
                {
                    bw.Write(obj.TM.myMap[i].maxX);
                    bw.Write(obj.TM.myMap[i].maxY);
                    bw.Write(obj.TM.myMap[i].Name);
                    bw.Write(obj.TM.myMap[i].PlayerAbove);

                    for (int b = 0; b < 5; b++)
                    {
                        for (int x = 0; x < obj.TM.myMap[i].maxX; x++)
                            for (int y = 0; y < obj.TM.myMap[i].maxY; y++)
                                bw.Write(obj.TM.myMap[i].Block[b].MyLayer[x,y]);
                    }

                    bw.Write(obj.TM.myMap[i].myLayer.Count);
                    for (int l = 0; l < obj.TM.myMap[i].myLayer.Count; l++)
                    {
                        bw.Write(obj.TM.myMap[i].myLayer[l].Name);
                        bw.Write(obj.TM.myMap[i].myLayer[l].Opacity);
                        bw.Write(obj.TM.myMap[i].myLayer[l].Order);
                        bw.Write(obj.TM.myMap[i].myLayer[l].Visible);

                        bw.Write(obj.TM.myMap[i].myLayer[l].myTile.Count);
                        for (int t = 0; t < obj.TM.myMap[i].myLayer[l].myTile.Count; t++)
                        {
                            bw.Write(obj.TM.myMap[i].myLayer[l].myTile[t].Width);
                            bw.Write(obj.TM.myMap[i].myLayer[l].myTile[t].Height);
                            bw.Write(obj.TM.myMap[i].myLayer[l].myTile[t].TS);
                            bw.Write(obj.TM.myMap[i].myLayer[l].myTile[t].Opacity);
                            bw.Write(obj.TM.myMap[i].myLayer[l].myTile[t].plcX);
                            bw.Write(obj.TM.myMap[i].myLayer[l].myTile[t].plcY);
                            bw.Write(obj.TM.myMap[i].myLayer[l].myTile[t].srcX);
                            bw.Write(obj.TM.myMap[i].myLayer[l].myTile[t].srcY);

                        }

                        bw.Write(obj.TM.myMap[i].myLayer[l].MiniLayer.Count);
                        for (int ml = 0; ml < obj.TM.myMap[i].myLayer[l].MiniLayer.Count; ml++)
                        {
                            bw.Write(obj.TM.myMap[i].myLayer[l].MiniLayer[ml].Name);
                            bw.Write(obj.TM.myMap[i].myLayer[l].MiniLayer[ml].Opacity);
                            bw.Write(obj.TM.myMap[i].myLayer[l].MiniLayer[ml].Order);
                            bw.Write(obj.TM.myMap[i].myLayer[l].MiniLayer[ml].Visible);

                            bw.Write(obj.TM.myMap[i].myLayer[l].MiniLayer[ml].myTile.Count);
                            for (int t = 0; t < obj.TM.myMap[i].myLayer[l].MiniLayer[ml].myTile.Count; t++)
                            {
                                bw.Write(obj.TM.myMap[i].myLayer[l].MiniLayer[ml].myTile[t].Width);
                                bw.Write(obj.TM.myMap[i].myLayer[l].MiniLayer[ml].myTile[t].Height);
                                bw.Write(obj.TM.myMap[i].myLayer[l].MiniLayer[ml].myTile[t].TS);
                                bw.Write(obj.TM.myMap[i].myLayer[l].MiniLayer[ml].myTile[t].Opacity);
                                bw.Write(obj.TM.myMap[i].myLayer[l].MiniLayer[ml].myTile[t].plcX);
                                bw.Write(obj.TM.myMap[i].myLayer[l].MiniLayer[ml].myTile[t].plcY);
                                bw.Write(obj.TM.myMap[i].myLayer[l].MiniLayer[ml].myTile[t].srcX);
                                bw.Write(obj.TM.myMap[i].myLayer[l].MiniLayer[ml].myTile[t].srcY);

                            }
                        }
                    }

                    for (int x = 0; x < obj.TM.myMap[i].maxX; x++)
                    {
                        for (int y = 0; y < obj.TM.myMap[i].maxY; y++)
                        {
                            bw.Write(obj.TM.myMap[i].EM[x, y].MyEvent.Count);
                            foreach (Event e in obj.TM.myMap[i].EM[x, y].MyEvent)
                                SaveEvent(e);
                        }
                    }
                }

                // Graphic Manager
                bw.Write(obj.GM.myResource.Count);
                for (int i = 0; i < obj.GM.myResource.Count; i++)
                {
                    bw.Write(obj.GM.myResource[i].Path);
                    bw.Write(obj.GM.myResource[i].Type);
                }

                // Actor Manager
                bw.Write(obj.AM.MyActor.Count);
                for (int i = 0; i < obj.AM.MyActor.Count; i++)
                {
                    bw.Write(obj.AM.MyActor[i].Name);
                    bw.Write(obj.AM.MyActor[i].Description);
                    bw.Write(obj.AM.MyActor[i].Level);
                    bw.Write(obj.AM.MyActor[i].Gender);
                    bw.Write(obj.AM.MyActor[i].Face);
                    bw.Write(obj.AM.MyActor[i].Sprite);
                    bw.Write(obj.AM.MyActor[i].Job);
                    bw.Write(obj.AM.MyActor[i].JobLevel);
                    bw.Write(obj.AM.MyActor[i].StatPoints);

                    bw.Write(obj.AM.MyActor[i].Stat.Length);
                    for (int s = 0; s < obj.AM.MyActor[i].Stat.Length; s++)
                    {
                        bw.Write(obj.AM.MyActor[i].Stat[s]);
                    }
                }

                bw.Write(obj.AM.MyFace.Count);
                for (int i = 0; i < obj.AM.MyFace.Count; i++)
                {
                    bw.Write(obj.AM.MyFace[i].Name);
                    bw.Write(obj.AM.MyFace[i].ID);
                }

                bw.Write(obj.AM.MySprite.Count);
                for (int i = 0; i < obj.AM.MySprite.Count; i++)
                {
                    bw.Write(obj.AM.MySprite[i].Name);
                    bw.Write(obj.AM.MySprite[i].ID);
                }
            }
        }

        public void LoadEvent(Game obj, List<Event> toAdd)
        {
            int type = br.ReadInt32();
            int count;

            switch (type)
            {
                case 0:
                    break;

                case 1:
                    break;

                case 2:
                    Warp w = new Warp();
                    w.WarpMap = br.ReadInt32();
                    w.WarpX = br.ReadInt32();
                    w.WarpY = br.ReadInt32();
                    w.Position = br.ReadInt32();

                    toAdd.Add(w);
                    break;

                case 3:
                    ConditionerLoc cl = new ConditionerLoc();
                    cl.ReqMap = br.ReadInt32();
                    cl.ReqX = br.ReadInt32();
                    cl.ReqY = br.ReadInt32();
                    cl.Position = br.ReadInt32();

                    count = br.ReadInt32();
                    for (int i = 0; i < count; i++)
                        LoadEvent(obj, cl.If);
                    count = br.ReadInt32();
                    for (int i = 0; i < count; i++)
                        LoadEvent(obj, cl.Else);

                    toAdd.Add(cl);
                    break;
                case 4:
                    ConditionerVariable cv = new ConditionerVariable();
                    cv.ReqVariable = br.ReadInt32();
                    cv.ReqValue = br.ReadInt32();

                    count = br.ReadInt32();
                    for (int i = 0; i < count; i++)
                        LoadEvent(obj, cv.If);
                    count = br.ReadInt32();
                    for (int i = 0; i < count; i++)
                        LoadEvent(obj, cv.Else);

                    toAdd.Add(cv);
                    break;
                case 5:
                    ConditionerSwitch cs = new ConditionerSwitch();
                    cs.ReqSwitch = br.ReadInt32();
                    cs.ReqValue = br.ReadBoolean();

                    count = br.ReadInt32();
                    for (int i = 0; i < count; i++)
                        LoadEvent(obj, cs.If);
                    count = br.ReadInt32();
                    for (int i = 0; i < count; i++)
                        LoadEvent(obj, cs.Else);

                    toAdd.Add(cs);
                    break;

                case 6:
                    SetSwitch ss = new SetSwitch();
                    ss.Switch = br.ReadInt32();
                    ss.Value = br.ReadBoolean();
                    ss.ChangeType = br.ReadInt32();

                    toAdd.Add(ss);
                    break;

                case 7:
                    SetVariable sv = new SetVariable();
                    sv.Variable = br.ReadInt32();
                    sv.Value = br.ReadInt32();
                    sv.ChangeType = br.ReadInt32();

                    toAdd.Add(sv);
                    break;
            }
        }

        public void LoadProject(string path, Game obj) // Load the actual project. This will be the load game function for the actual game as well. Along with others game-only-related stuffs like Character save and such
        {
            Tile _tempTile = new Tile();
            Tileset _tempTileset = new Tileset();
            TileLayer _tempLayer = new TileLayer();
            TileLayer _tempMiniLayer = new TileLayer();
            TileMap _tempMap = new TileMap();
            Actor _tempActor = new Actor();
            Sprites _tempSprite = new Sprites();
            Face _tempFace = new Face();
            Switch _tempSwitch = new Switch();
            Variable _tempVariable = new Variable();

            GResource _tempResource = new GResource();

            using (br = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                obj.Name = br.ReadString();
                obj.Path = br.ReadString();
                obj.Author = br.ReadString();
                obj.Description = br.ReadString();
                obj.SubName = br.ReadString();
                obj.TileX = br.ReadInt32();
                obj.TileY = br.ReadInt32();
                obj.StartMap = br.ReadInt32();
                obj.StartX = br.ReadInt32();
                obj.StartY = br.ReadInt32();

                int max = br.ReadInt32();
                for (int i = 0; i < max; i++)
                {
                    _tempSwitch = new Switch();
                    _tempSwitch.Name = br.ReadString();

                    obj.MySwitch.Add(_tempSwitch);
                }

                max = br.ReadInt32();

                for (int i = 0; i < max; i++)
                {
                    _tempVariable = new Variable();
                    _tempVariable.Name = br.ReadString();

                    obj.MyVariable.Add(_tempVariable);
                }

                //Initial Party
                max = br.ReadInt32();
                for (int i = 0; i < max; i++)
                {
                    obj.InitialParty.Add(br.ReadInt32());
                }

                //Please keep all the non engine related stuff up here

                // From this point onward is all engine related stuff

                // Tile Engine
                max = br.ReadInt32();
                for (int i = 0; i < max; i++)
                {
                    _tempTileset = new Tileset();
                    _tempTileset.Name = br.ReadString();
                    _tempTileset.ID = br.ReadInt32();
                    obj.TM.myTileset.Add(_tempTileset);
                }

                max = br.ReadInt32();
                for (int i = 0; i < max; i++)
                {
                    _tempMap = new TileMap();
                    _tempMap.maxX = br.ReadInt32();
                    _tempMap.maxY = br.ReadInt32();

                    _tempMap.InitEvent();

                    _tempMap.Name = br.ReadString();
                    _tempMap.PlayerAbove = br.ReadInt32();

                    _tempMap.Block = new TileProperty[5];

                    for (int b = 0; b < 5; b++)
                    {
                        TileProperty _tempTileProperty = new TileProperty(_tempMap.maxX, _tempMap.maxY);
                        for (int x = 0; x < _tempMap.maxX; x++)
                            for (int y = 0; y < _tempMap.maxY; y++)
                                _tempTileProperty.MyLayer[x, y] = br.ReadByte();

                        _tempMap.Block[b] = _tempTileProperty;
                    }

                    int secmax = br.ReadInt32();
                    for (int l = 0; l < secmax; l++)
                    {
                        _tempLayer = new TileLayer();
                        _tempLayer.Name = br.ReadString();
                        _tempLayer.Opacity = br.ReadInt32();
                        _tempLayer.Order = br.ReadInt32();
                        _tempLayer.Visible = br.ReadBoolean();

                        int thimax = br.ReadInt32();
                        for (int t = 0; t < thimax; t++)
                        {
                            _tempTile = new Tile();
                            _tempTile.Width = br.ReadInt32();
                            _tempTile.Height = br.ReadInt32();
                            _tempTile.TS = br.ReadInt32();
                            _tempTile.Opacity = br.ReadInt32();
                            _tempTile.plcX = br.ReadInt32();
                            _tempTile.plcY = br.ReadInt32();
                            _tempTile.srcX = br.ReadInt32();
                            _tempTile.srcY = br.ReadInt32();

                            _tempLayer.addTile(_tempTile);
                        }

                        thimax = br.ReadInt32();
                        for (int ml = 0; ml < thimax; ml++)
                        {
                            _tempMiniLayer = new TileLayer();
                            _tempMiniLayer.Name = br.ReadString();
                            _tempMiniLayer.Opacity = br.ReadInt32();
                            _tempMiniLayer.Order = br.ReadInt32();
                            _tempMiniLayer.Visible = br.ReadBoolean();

                            int foumax = br.ReadInt32();
                            for (int t = 0; t < foumax; t++)
                            {
                                _tempTile = new Tile();
                                _tempTile.Width = br.ReadInt32();
                                _tempTile.Height = br.ReadInt32();
                                _tempTile.TS = br.ReadInt32();
                                _tempTile.Opacity = br.ReadInt32();
                                _tempTile.plcX = br.ReadInt32();
                                _tempTile.plcY = br.ReadInt32();
                                _tempTile.srcX = br.ReadInt32();
                                _tempTile.srcY = br.ReadInt32();

                                _tempMiniLayer.addTile(_tempTile);
                            }

                            _tempLayer.MiniLayer.Add(_tempMiniLayer);
                        }

                        _tempMap.myLayer.Add(_tempLayer);
                    }

                    for (int x = 0; x < _tempMap.maxX; x++)
                    {
                        for (int y = 0; y < _tempMap.maxY; y++)
                        {
                            int count = br.ReadInt32();
                            for (int c = 0; c < count; c++)
                                LoadEvent(obj, _tempMap.EM[x, y].MyEvent);
                        }
                    }

                    obj.TM.myMap.Add(_tempMap);
                }

                // Graphic Manager
                max = br.ReadInt32();
                for (int i = 0; i < max; i++)
                {
                    _tempResource = new GResource();

                    _tempResource.Path = br.ReadString();
                    _tempResource.Type = br.ReadInt32();

                    obj.GM.myResource.Add(_tempResource);
                }

                // Actor Manager
                max = br.ReadInt32();
                for (int i = 0; i < max; i++)
                {
                    _tempActor = new Actor();
                    _tempActor.Name = br.ReadString();
                    _tempActor.Description = br.ReadString();
                    _tempActor.Level = br.ReadInt32();
                    _tempActor.Gender = br.ReadInt32();
                    _tempActor.Face = br.ReadInt32();
                    _tempActor.Sprite = br.ReadInt32();
                    _tempActor.Job = br.ReadInt32();
                    _tempActor.JobLevel = br.ReadInt32();
                    _tempActor.StatPoints = br.ReadInt32();

                    _tempActor.Stat = new int[br.ReadInt32()];
                    for (int s = 0; s < _tempActor.Stat.Length; s++)
                    {
                        _tempActor.Stat[s] = br.ReadInt32();
                    }

                    obj.AM.MyActor.Add(_tempActor);
                }

                max = br.ReadInt32();
                for (int i = 0; i < max; i++)
                {
                    _tempFace = new Face();
                    _tempFace.Name = br.ReadString();
                    _tempFace.ID = br.ReadInt32();

                    obj.AM.MyFace.Add(_tempFace);
                }

                max = br.ReadInt32();
                for (int i = 0; i < max; i++)
                {
                    _tempSprite = new Sprites();
                    _tempSprite.Name = br.ReadString();
                    _tempSprite.ID = br.ReadInt32();

                    obj.AM.MySprite.Add(_tempSprite);
                }
            }
        }

        #endregion Method
    }
}
