using System.Text.Json;
using DetailerCalculator;
var file=Path.GetFullPath(Path.Combine(AppContext.BaseDirectory,"../../../../fixtures/numeric-compatibility.v1.json"));
using var doc=JsonDocument.Parse(File.ReadAllText(file));var count=0;
foreach(var row in doc.RootElement.GetProperty("cases").EnumerateArray()){
 var args0=row.GetProperty("args").EnumerateArray().Select(x=>x.GetDecimal()).ToArray();
 var a=args0[0];var b=args0.Length>1?args0[1]:0;
 decimal result=row.GetProperty("operation").GetString() switch {
  "footToDecimalInch"=>Conversions.FootToDecimalInch(a),"footToDecimalFoot"=>Conversions.FootToDecimalFoot(a),
  "decimalInchToFoot"=>Conversions.DecimalInchToFoot(a),"decimalFootToFoot"=>Conversions.DecimalFootToFoot(a),
  "subtract"=>MathFunctions.DoMath("Subtract",a,b,false),"divide"=>MathFunctions.DoMath("Divide",a,b,false),"add"=>MathFunctions.DoMath("Add",a,b,false),
  "baseRiseToSlope"=>TrigFunctions.BaseRiseToSlope(a,b),"s2r"=>TrigFunctions.SlopeToRise(a,b),"b2r"=>TrigFunctions.BaseToRise(a,b),_=>throw new Exception("Unknown fixture operation")};
 if(Math.Abs(result-row.GetProperty("expected").GetDecimal())>row.GetProperty("tolerance").GetDecimal())throw new Exception("Fixture mismatch: "+row.GetProperty("id").GetString());
 count++;
}
Console.WriteLine($"{count} shared numeric fixtures passed against desktop source.");
