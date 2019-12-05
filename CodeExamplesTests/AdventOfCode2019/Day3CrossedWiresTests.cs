﻿using System.Collections.Generic;
using CodeExamples.AdventOfCode2019;
using NUnit.Framework;

namespace CodeExamplesTests.AdventOfCode2019
{
    internal class Day3CrossedWiresTests
    {
        [Test]
        public void TyrannyOfTheRocketEquationTestExample1()
        {
            List<string> input2 = new List<string> { "R8", "U5", "L5", "D3" };
            List<string> input = new List<string> { "U7", "R6", "D4", "L4" };
            var crossedWires = new Day3CrossedWires();
            crossedWires.AddWire1CrossedWires(input);
            var shortest = crossedWires.AddWire1CrossedWires(input2);
            Assert.That(shortest, Is.EqualTo(6));
        }

        [Test]
        public void TyrannyOfTheRocketEquationTestExample2()
        {
            List<string> input2 = new List<string> { "U62", "R66", "U55", "R34", "D71", "R55", "D58", "R83" };
            List<string> input = new List<string> { "R75", "D30", "R83", "U83", "L12", "D49", "R71", "U7", "L72" };

            var crossedWires = new Day3CrossedWires();
            crossedWires.AddWire1CrossedWires(input);
            var shortest = crossedWires.AddWire1CrossedWires(input2);
            Assert.That(shortest, Is.EqualTo(159));
        }

        [Test]
        public void TyrannyOfTheRocketEquationTestExample3()
        {
            List<string> input2 = new List<string> { "R98", "U47", "R26", "D63", "R33", "U87", "L62", "D20", "R33", "U53", "R51" };
            List<string> input = new List<string> { "U98", "R91", "D20", "R16", "D67", "R40", "U7", "R15", "U6", "R7" };
            var crossedWires = new Day3CrossedWires();
            crossedWires.AddWire1CrossedWires(input);
            var shortest = crossedWires.AddWire1CrossedWires(input2);
            Assert.That(shortest, Is.EqualTo(135));
        }

        [Test]
        public void TyrannyOfTheRocketEquationActual()
        {
            List<string> input2 = new List<string>
            {
                "R1002", "D715", "R356", "D749", "L255", "U433", "L558", "D840", "R933", "U14", "L285", "U220", "L88",
                "D477", "R36", "U798", "R373", "U378", "R305", "D341", "R959", "D604", "R717", "D911", "L224", "D32",
                "R481", "D508", "L203", "U445", "L856", "U44", "L518", "U909", "R580", "U565", "R484", "D170", "R356",
                "U614", "R278", "U120", "R540", "D330", "R124", "D555", "R890", "U445", "L876", "D948", "R956", "D503",
                "R391", "U564", "R624", "D642", "L821", "U924", "L921", "U869", "R104", "U376", "L693", "U812", "R758",
                "U200", "L515", "U435", "R505", "U22", "R707", "U926", "R261", "D332", "R535", "D704", "L561", "U476",
                "R225", "U168", "L784", "D794", "R311", "D426", "R813", "U584", "L831", "D258", "R241", "D665", "R550",
                "D709", "R261", "U557", "L670", "D823", "L297", "U951", "R634", "D647", "R699", "U907", "L219", "U481",
                "L583", "D854", "L898", "U535", "R648", "U307", "L870", "D748", "R768", "D502", "L15", "U684", "R476",
                "D591", "L531", "D881", "L466", "U135", "R445", "U813", "R950", "D303", "L590", "U938", "R630", "D233",
                "R567", "U739", "L446", "U689", "R585", "D892", "R741", "U849", "R629", "D972", "L625", "D524", "L715",
                "D936", "L328", "U102", "R864", "U859", "L827", "U162", "L886", "D785", "R359", "D38", "R51", "U999",
                "R560", "U415", "L840", "U736", "R552", "D277", "R722", "D444", "R164", "U335", "L129", "D873", "L499",
                "U847", "R84", "U780", "R104", "U879", "R938", "D468", "L575", "D668", "L143", "U917", "R86", "D562",
                "R595", "U924", "R807", "U76", "L44", "D685", "R936", "U876", "R570", "U782", "L139", "D815", "R89",
                "D976", "R84", "U446", "R238", "U853", "L603", "U869", "R312", "U970", "R387", "U131", "L647", "D383",
                "R161", "D818", "L765", "U291", "L423", "D753", "R277", "U840", "R23", "U265", "R298", "U665", "R522",
                "D955", "R26", "D320", "R347", "U952", "R743", "U782", "L780", "D20", "L393", "U855", "L279", "D969",
                "L923", "D902", "L818", "U855", "L927", "D342", "R769", "U517", "L485", "U176", "R14", "U683", "L632",
                "U198", "R656", "U444", "R41", "D911", "R99", "U880", "L363", "D15", "L894", "D782", "R612", "D677",
                "R469", "D166", "R61", "U284", "R474", "U222", "L687", "D502", "R690", "U619", "R536", "D663", "L54",
                "D660", "L804", "D697", "R67", "U116", "R842", "D785", "R277", "U978", "L920", "D926", "R681", "D957",
                "L582", "U441", "L593", "U686", "R829", "U937", "L924", "U965", "R727", "D964", "R468", "U240", "R934",
                "D266", "R416"
            };
            List<string> input = new List<string>
            {
                "L998", "U258", "R975", "U197", "R680", "D56", "R898", "D710", "R475", "U909", "L201", "D579", "L21",
                "U743", "R832", "D448", "R216", "D136", "R83", "U413", "R167", "U138", "R102", "U122", "L290", "D49",
                "L93", "D941", "L625", "U709", "R129", "D340", "L322", "D27", "R440", "U692", "R368", "D687", "L246",
                "D425", "R823", "U287", "L436", "U999", "R90", "U663", "R470", "U177", "R956", "D981", "L767", "D780",
                "R610", "D644", "R238", "D416", "R402", "D327", "L680", "D367", "L94", "D776", "L331", "D745", "R846",
                "D559", "R113", "U158", "R125", "D627", "L898", "D212", "L80", "D184", "L386", "U943", "R122", "D614",
                "L868", "D600", "R912", "U501", "R25", "D887", "R310", "U872", "L157", "U865", "L382", "U959", "R712",
                "D248", "L343", "U819", "L763", "U886", "R582", "D631", "L835", "U443", "L917", "D934", "L333", "U470",
                "R778", "U142", "R384", "U589", "R306", "U933", "L206", "D199", "L497", "D406", "L212", "U439", "L15",
                "U985", "R505", "D502", "R934", "D966", "R429", "U810", "R588", "U367", "L424", "U804", "R767", "U703",
                "R885", "U568", "R748", "U209", "L319", "U305", "L941", "D184", "R398", "U681", "L411", "U414", "L90",
                "U711", "L575", "D368", "L986", "U29", "R982", "U361", "L501", "D970", "R558", "D887", "L241", "U506",
                "R578", "D932", "R911", "U621", "L153", "U200", "L873", "U711", "L843", "U549", "R72", "U377", "R915",
                "D79", "L378", "U66", "L989", "D589", "L341", "D350", "L200", "D78", "R944", "U876", "L794", "U643",
                "R871", "D909", "L353", "D54", "R651", "U338", "R857", "D938", "R636", "D301", "R728", "U318", "R530",
                "D589", "L682", "U784", "L428", "D879", "L207", "D247", "L53", "U312", "L488", "D534", "L998", "U512",
                "L628", "D957", "L994", "D747", "L804", "U399", "L801", "D500", "R791", "D980", "R839", "U564", "L81",
                "U461", "R615", "U863", "R308", "D564", "R843", "U579", "R792", "D472", "R229", "D153", "L21", "D647",
                "R425", "D54", "L470", "U330", "R285", "D81", "L221", "U168", "R970", "D624", "R815", "U189", "L812",
                "U195", "L654", "U108", "R820", "U786", "L932", "U657", "L605", "D164", "L788", "D393", "L717", "D49",
                "R615", "D81", "L91", "U322", "L150", "D368", "R434", "D861", "L859", "D911", "R161", "U576", "L671",
                "U992", "L745", "U585", "R440", "D731", "R740", "U584", "L867", "D906", "R176", "U72", "L323", "U329",
                "L445", "D667", "R626", "D111", "L895", "D170", "R957", "D488", "R214", "D354", "L215", "U486", "L665",
                "D266", "L987"
            };
            var crossedWires = new Day3CrossedWires();
            crossedWires.AddWire1CrossedWires(input);
            var shortest = crossedWires.AddWire1CrossedWires(input2);
            var steps = crossedWires.shortestSteps;
            Assert.That(shortest, Is.EqualTo(3247));
            Assert.That(steps, Is.EqualTo(48054));
        }

        [Test]
        public void TyrannyOfTheRocketPart2TestExample1()
        {
            List<string> input = new List<string> { "R75", "D30", "R83", "U83", "L12", "D49", "R71", "U7", "L72" };
            List<string> input2 = new List<string> { "U62", "R66", "U55", "R34", "D71", "R55", "D58", "R83" };

            var crossedWires = new Day3CrossedWires();
            crossedWires.AddWire1CrossedWires(input);
            crossedWires.AddWire1CrossedWires(input2);
            Assert.That(crossedWires.shortestSteps, Is.EqualTo(610));
        }

        [Test]
        public void TyrannyOfTheRocketPart2TestExample3()
        {
            List<string> input2 = new List<string> { "R98", "U47", "R26", "D63", "R33", "U87", "L62", "D20", "R33", "U53", "R51" };
            List<string> input = new List<string> { "U98", "R91", "D20", "R16", "D67", "R40", "U7", "R15", "U6", "R7" };
            var crossedWires = new Day3CrossedWires();
            crossedWires.AddWire1CrossedWires(input);
            crossedWires.AddWire1CrossedWires(input2);
            Assert.That(crossedWires.shortestSteps, Is.EqualTo(410));
        }
    }
}