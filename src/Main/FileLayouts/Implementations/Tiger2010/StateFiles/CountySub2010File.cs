﻿using TAMU.GeoInnovation.Applications.Census.ReferenceDataImporter.FileLayouts.AbstractClasses.Tiger2010.StateFiles;

namespace TAMU.GeoInnovation.Applications.Census.ReferenceDataImporter.MongoDB.FileLayouts.Implementations.Tiger2010.StateFiles
{
    public class CountySub2010File : AbstractTiger2010ShapefileStateFileLayout
    {

        public CountySub2010File(string stateName)
            : base(stateName)
        {

            FileName = "cousub10.zip";

            HasSoundexColumns = true;
            HasSoundexDMColumns = true;
            SoundexColumns = new string[] { "Name10" };
            SoundexDMColumns = new string[] { "Name10" };

            //ExcludeColumns = new string[] { "Name00_Soundex", "Name00_SoundexDM" };

            SQLCreateTable += //"CREATE TABLE [" + OutputTableName + "] (";
            SQLCreateTable += "stateFp10|";
            SQLCreateTable += "countyFp10|";
            SQLCreateTable += "cousubFp10|";
            SQLCreateTable += "cousubNs10|";
            SQLCreateTable += "GeoId10|";
            SQLCreateTable += "Name10|";
            SQLCreateTable += "Name10_Soundex|";
            SQLCreateTable += "Name10_SoundexDM|";
            SQLCreateTable += "NameLsad10|";
            SQLCreateTable += "lsad10|";
            SQLCreateTable += "classFp10|";
            SQLCreateTable += "Mtfcc10|";
            SQLCreateTable += "cnectaFp10|";
            SQLCreateTable += "nectaFp10 |";
            SQLCreateTable += "nctadvFp10 |";
            SQLCreateTable += "FuncStat10|";
            SQLCreateTable += "aLand10 |";
            SQLCreateTable += "aWater10|";
            SQLCreateTable += "intPtLat10 |";
            SQLCreateTable += "intPtLon10|";
            SQLCreateTable += "shapeType|";
            SQLCreateTable += "shapeGeog|";
            SQLCreateTable += "shapeGeogAsGeoJSON|";
            SQLCreateTable += "shapeGeom|";
            SQLCreateTable += "shapeGeomAsGeoJSON";

            //SQLCreateTableIndexes += " CREATE NONCLUSTERED INDEX [IDX_" + OutputTableName + "Name10] ON [dbo].[" + OutputTableName + "] (Name10) WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY];";
            //SQLCreateTableIndexes += " CREATE NONCLUSTERED INDEX [IDX_" + OutputTableName + "Name10_Soundex] ON [dbo].[" + OutputTableName + "] (Name10_Soundex) WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY];";
            //SQLCreateTableIndexes += " CREATE NONCLUSTERED INDEX [IDX_" + OutputTableName + "Name10_SoundexDM] ON [dbo].[" + OutputTableName + "] (Name10_SoundexDM) WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY];";
        }
    }
}
