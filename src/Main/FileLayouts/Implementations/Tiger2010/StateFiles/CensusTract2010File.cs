using TAMU.GeoInnovation.Applications.Census.ReferenceDataImporter.FileLayouts.AbstractClasses.Tiger2010.StateFiles;

namespace TAMU.GeoInnovation.Applications.Census.ReferenceDataImporter.MongoDB.FileLayouts.Implementations.Tiger2010.StateFiles
{
    public class CensusTract2010File : AbstractTiger2010ShapefileStateFileLayout
    {



        public CensusTract2010File(string stateName)
            : base(stateName)
        {

            ExcludeColumns = new string[]
            {
                "uniqueId"
            };


            FileName = "tract10.zip";

            SQLCreateTable +=// "CREATE TABLE [" + OutputTableName + "] (";
            SQLCreateTable += "uniqueId|";
            SQLCreateTable += "stateFp10|";
            SQLCreateTable += "countyFp10|";
            SQLCreateTable += "TractCe10|";
            SQLCreateTable += "GEOID10|";
            SQLCreateTable += "Name10|";
            SQLCreateTable += "NameLsad10|";
            SQLCreateTable += "Mtfcc10|";
            SQLCreateTable += "FuncStat10|";
            SQLCreateTable += "INTPTLAT10|";
            SQLCreateTable += "INTPTLON10|";
            SQLCreateTable += "shapeType|";
            SQLCreateTable += "shapeGeog|";
            SQLCreateTable += "shapeGeogAsGeoJSON|";
            SQLCreateTable += "shapeGeom|";
            SQLCreateTable += "shapeGeomAsGeoJSON";
        }
    }
}
