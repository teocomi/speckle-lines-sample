// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using Objects.Geometry;
using Speckle.Core.Api;
using Speckle.Core.Models;

Console.WriteLine("Generating lines...");

var line1 = new Line(new Point(0, 0, 0), new Point(100, -200, 50));
var line2 = new Line(new Point(0, 0, 0), new Point(500, 100, 600));

var commitData = new Base();

commitData["data"] = new List<Base> { line1, line2 };
var stream = "https://speckle.xyz/streams/4d97b0a28e";
string commitId = await Helpers.Send(stream, commitData, "a couple of lines");

Console.WriteLine($"Lines sent: https://speckle.xyz/streams/4d97b0a28e/commits/{commitId}");
Console.ReadLine();