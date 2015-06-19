using TAMU.GeoInnovation.Applications.Census.ReferenceDataImporter.FileLayouts.AbstractClasses.Tiger2010.StateFiles;

namespace TAMU.GeoInnovation.Applications.Census.ReferenceDataImporter.MongoDB.FileLayouts.Implementations.Tiger2010.StateFiles
{
    public class CensusBlock2010File : AbstractTiger2010ShapefileStateFileLayout
    {
        

        public CensusBlock2010File(string stateName)
            : base(stateName)
        {

            ExcludeColumns = new string[] 
            { 
                "uniqueId",
            };

            FileName = "tabblock10.zip";

            SQLCreateTable += 
            SQLCreateTable += "uniqueId|";
            SQLCreateTable += "stateFp10|";
            SQLCreateTable += "countyFp10|";
            SQLCreateTable += "TractCe10|";
            SQLCreateTable += "BlockCe10|";
            SQLCreateTable += "GeoId10|";
            SQLCreateTable += "Name10|";
            SQLCreateTable += "Mtfcc10|";
            SQLCreateTable += "UR10|";
            SQLCreateTable += "UAce10|";
            SQLCreateTable += "FuncStat10|";
            SQLCreateTable += "aLand10|";
            SQLCreateTable += "aWater10|";
            SQLCreateTable += "intPtLat10|";
            SQLCreateTable += "intPtLon10|";
            SQLCreateTable += "shapeType|";
            SQLCreateTable += "shapeGeog|";
            SQLCreateTable += "shapeGeogAsGeoJSON|";
            SQLCreateTable += "shapeGeom|";
            SQLCreateTable += "shapeGeomAsGeoJSON";
            

        }
    }
}
