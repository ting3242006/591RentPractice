using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _591RentPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rentalListings = RentalListingData.GetData();
            int a = 10;
            // data.Count == 100
            //🟡 中等難度
            //第 1 題
            //平台上有哪些城市有提供租屋資訊？請列出不重複的城市清單，並按照筆畫由少到多排序。
            //var cities = rentalListings.Select(x => x.LocationCity).Distinct().OrderBy(x => x).ToList();
            //foreach (var city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //第 2 題
            //我對寵物過敏的朋友想租房，但他只想看「不可養寵物」且「有電梯」的整層住家，請幫他篩出這些物件並依租金由低到高排列。
            //var result = rentalListings
            //    .Where(x => !x.AllowsPets && x.HasElevator && x.Type == "整層住家")
            //    .OrderBy(x => x.Rent)
            //    .ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.LocationCity} {item.LocationDistrict} {item.Rent}");
            //}
            //第 3 題
            //請問這 100 筆資料中，有沒有任何一間房子同時具備「有車位」、「有陽台」、「有冰箱」三個條件？
            // All=>集合中所有資料都需要符合條件,Any=> 集合中有任何一筆資料符合條件
            //var result = rentalListings
            //    .Where(x => x.HasParking == true && x.HasBalcony == true && x.HasFridge == true)
            //    .ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.LocationCity} {item.LocationDistrict}");
            //}

            //第 4 題
            //我想知道每種房屋類型（整層住家、獨立套房…）各有幾筆資料，請統計各類型的數量。
            //var result = rentalListings
            //    .GroupBy(x => x.Type)
            //    .Select(g => new
            //    {
            //        g.Key,
            //        Count = g.Count(),
            //        AvgPrice = g.Average(gp => gp.Rent)
            //    })
            //    .ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Key} {item.Count} , Price:{item.AvgPrice}");
            //}

            //第 5 題
            //請將所有物件依照坪數分成兩組：15 坪以下為「小坪數」、15 坪以上為「一般坪數」，並分別計算各組的平均租金。
            //var result = rentalListings
            //    .GroupBy(x => x.SizePing >= 15 ? "一般" : "小")
            //    .Select(g => new
            //    {
            //        Key = g.Key,
            //        AvgPrice = g.Average(gp => gp.Rent)
            //    })
            //    .ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Key}, AvgPrice:{item.AvgPrice}");
            //}
            //第 6 題
            //我想找「台北市」或「新北市」、租金在 15,000 元以下、且有網路的物件，請列出這些物件的城市、區域與租金。
            //var result = rentalListings
            //    .Where(x => (x.LocationCity == "台北市" || x.LocationCity == "新北市")
            //    && x.Rent <= 15000
            //    && x.HasInternet)
            //    .ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.LocationCity}, {item.LocationDistrict}, {item.Rent}");
            //}
            //第 7 題
            //請確認這批資料中，是否「所有」電梯大樓的物件都有標記 HasElevator = true？
            // 所有可以用"All"
            //var result = rentalListings
            //    .Where(x => x.BuildingType == "電梯大樓")
            //    .All(x => x.HasElevator);

            //Console.WriteLine(result);

            //🟠 中高難度
            //第 8 題
            //請統計每個城市的平均租金，並找出平均租金最高的城市。
            //var result = rentalListings
            //    .GroupBy(x => x.LocationCity)
            //    .Select(g => new
            //    {
            //        City = g.Key,
            //        AvgRent = g.Average(x => x.Rent)
            //    })
            //    .OrderByDescending(x => x.AvgRent)
            //    .ToList();
            //var highestCity = result.First();

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"各城市平均租金: {item.City}, {item.AvgRent}");
            //}

            //Console.WriteLine($"平均租金最高城市: {highestCity.City}, 平均租金: {highestCity.AvgRent}");


            // 第 8-1 題
            // 請列出所有縣市中，租金高於全台灣平均租金的縣市有哪些
            //var TaiwanAvgRent = rentalListings.Average(x => x.Rent);

            //var cities = rentalListings
            //    .GroupBy(x => x.LocationCity)
            //    .Select(g => new
            //    {
            //        City = g.Key,
            //        AvgRent = g.Average(x => x.Rent)
            //    })
            //    .Where(x => x.AvgRent > TaiwanAvgRent)
            //    .ToList();
            //Console.WriteLine($"全台灣平均租金: {TaiwanAvgRent}");
            //foreach (var item in cities)
            //{
            //    Console.WriteLine($"{item.City} {item.AvgRent}");
            //}
            // 第8-2題
            // 請列出每一個縣市中，物件租金高於該縣市的平均租金的物件有哪些?
            //var cities = rentalListings
            //    .GroupBy(x => x.LocationCity)
            //    .Select(g => new
            //    {
            //        City = g.Key,
            //        AvgRent = g.Average(x => x.Rent)
            //    })
            //    .ToList();
            //foreach (var item in cities)
            //{
            //    Console.WriteLine($"各縣市平均租金: {item.City} {item.AvgRent}");
            //}

            //var result = rentalListings
            //    .GroupBy(x => x.LocationCity)
            //    .SelectMany(x => x.Where(g => g.Rent > x.Average(y => y.Rent)));
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.LocationCity} {item.LocationDistrict} {item.Rent}");
            //}


            //第 9 題
            //我想建立一個快速查找工具：以「城市＋區域」作為 Key（例如：台北市 - 大安區），對應該區所有物件的清單作為 Value，請建立這個字典結構。
            //var result = rentalListings
            //    .GroupBy(x => $"{x.LocationCity} {x.LocationDistrict}")
            //    .ToDictionary(
            //        g => g.Key,
            //        g => g.ToList()
            //    );
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Key} -> {item.Value.Count} 筆物件");
            //}

            //第 10 題
            //請找出每種建物型態中，坪數最大的那一筆物件，列出其型態、坪數、租金與所在城市。
            //var result = rentalListings
            //    .GroupBy(x => x.BuildingType)
            //    .Select(g => g.OrderByDescending(x => x.SizePing).First())
            //    .ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.BuildingType} 最大坪數:{item.SizePing} 租金:{item.Rent} {item.LocationCity}");
            //}
            //第 11 題
            //我想了解「近捷運」這個條件對租金的影響，請分別計算「近捷運」與「不近捷運」兩組的平均租金與物件數量。
            //var result = rentalListings
            //    .GroupBy(x => x.IsNearMRT)
            //    .Select(g => new
            //    {
            //        NearMRT = g.Key,
            //        Count = g.Count(),
            //        AvgRent = g.Average(x => x.Rent)
            //    })
            //    .ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"近捷運:{item.NearMRT} 物件:{item.Count} 平均租金:{item.AvgRent}");
            //}
            //第 12 題
            //請統計所有物件的設備配備情況：HasAC、HasWasher、HasFridge、HasWaterHeater、HasGas、HasInternet、HasBed 這七項設備，各自有多少筆物件擁有，並由多到少排序。（提示方向：想想怎麼把多個欄位「展平」成一份清單）
            //var result = rentalListings
            //     .SelectMany(x => new[]
            //         {
            //            new { Name = "AC", Value = x.HasAC },
            //            new { Name = "Washer", Value = x.HasWasher },
            //            new { Name = "Fridge", Value = x.HasFridge },
            //            new { Name = "WaterHeater", Value = x.HasWaterHeater },
            //            new { Name = "Gas", Value = x.HasGas },
            //            new { Name = "Internet", Value = x.HasInternet },
            //            new { Name = "Bed", Value = x.HasBed }
            //         })
            //     .Where(x => x.Value)
            //     .GroupBy(x => x.Name)
            //     .Select(g => new
            //     {
            //         Equip = g.Key,
            //         Count = g.Count()
            //     })
            //     .OrderByDescending(x => x.Count)
            //    .ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Equip} {item.Count}");
            //}

            //第 13 題
            //請計算每個城市中，「可養寵物」的物件佔該城市總物件數的百分比，並列出百分比最高的前三名城市。
            //var result = rentalListings
            //    .GroupBy(x => x.LocationCity)
            //    .Select(g => new
            //    {
            //        City = g.Key,
            //        Percent = (double)g.Count(x => x.AllowsPets) / g.Count()
            //    })
            //    .OrderByDescending(x => x.Percent)
            //    .Take(3)
            //    .ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.City} 比例: {item.Percent}");
            //}
            //第 14 題
            //假設我要寄行銷信給房東，需要產生一份「城市 → 該城市所有不重複區域清單」的字典，請建立這個資料結構。
            //var result = rentalListings
            //    .GroupBy(x => x.LocationCity)
            //    .ToDictionary
            //    (
            //      g => g.Key,
            //      g => g.Select(x => x.LocationDistrict).Distinct().ToList()
            //    );

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Key}, {string.Join(",", item.Value)}");
            //}
            //🔴 高難度
            //第 15 題
            //請依照每坪租金（Rent / SizePing）由高到低排出前 10 名，並列出其城市、區域、類型與每坪租金（四捨五入到整數）。
            //var result = rentalListings
            //    .Select(x => new
            //    {
            //        x.LocationCity,
            //        x.LocationDistrict,
            //        x.Type,
            //        RentPrice = Math.Round(x.Rent / x.SizePing)
            //    })
            //    .OrderByDescending(X => X.RentPrice)
            //    .Take(10)
            //    .ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.LocationCity} {item.LocationDistrict} {item.Type} {item.RentPrice}");
            //}
            //第 16 題
            //我想分析「樓層高低是否影響租金」，請將物件依樓層分為三組：低樓層（1–3 樓）、中樓層（4–8 樓）、高樓層（9 樓以上），統計各組的平均租金、最高租金與物件數量。
            //var result = rentalListings
            //    .GroupBy(x =>
            //    {
            //        if (x.Floor <= 3) return "低樓層";
            //        if (x.Floor <= 8) return "中樓層";
            //        return "高樓層";
            //    })
            //    .Select(g => new
            //    {
            //        Key = g.Key,
            //        AvgRent = g.Average(x => x.Rent),
            //        MaxRent = g.Max(x => x.Rent),
            //        Count = g.Count()
            //    })
            //    .ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Key}, 平均租金: {item.AvgRent} 最高租金: {item.MaxRent} 物件數量: {item.Count}");
            //}

            //第 17 題
            //請找出「設備最齊全」的物件，定義為 HasAC、HasWasher、HasFridge、HasWaterHeater、HasGas、HasInternet、HasBed 七項設備全部為 true 的物件，並計算這些物件的平均租金，與全體平均租金相比，差距是多少？
            //var fullEquip = rentalListings
            //    .Where(x => x.HasAC
            //    && x.HasWasher
            //    && x.HasFridge
            //    && x.HasWasher
            //    && x.HasGas
            //    && x.HasInternet
            //    && x.HasBed)
            //    .ToList();

            //var fullEquipAvg = fullEquip.Average(x => x.Rent);
            //var allAvg = rentalListings.Average(x => x.Rent);

            //Console.WriteLine($"全設備平均租金{fullEquipAvg}, 全部平均租金: {allAvg}, 差距: {fullEquipAvg - allAvg}");
            //第 18 題
            //請模擬一個「推薦引擎」：給定條件為租金上限 12,000 元、需要有網路、需要有冷氣，請用 Enumerable.Repeat 將每筆符合條件的物件重複產生 3 筆（模擬三個推薦名額），並統計最終推薦清單共有幾筆。
            //var result = rentalListings
            //    .Where(x => x.Rent <= 12000 && x.HasInternet && x.HasAC)
            //    .SelectMany(x => Enumerable.Repeat(x, 3))
            //    .ToList();

            //Console.WriteLine(result.Count);
            //var data = Enumerable.Repeat(new RentalListing(), 5);

            //第 19 題
            //請建立一份「城市租屋市場報告」的資料結構：以城市分組，每組包含（物件總數、平均租金、最常見的房屋類型、有電梯的物件比例），並依物件總數由多到少排序。
            var result = rentalListings
                .GroupBy(x => x.LocationCity)
                .Select(g => new
                {
                    City = g.Key,
                    Count = g.Count(),
                    AvgRent = g.Average(x => x.Rent),
                    MostType = g.GroupBy(x => x.Type).OrderByDescending(x => x.Count()).First().Key,
                    ElevatorRatio = (g.Count(x => x.HasElevator) / (double)g.Count() * 100.0)
                })
                .OrderByDescending(x => x.Count)
                .ToList();

            foreach (var item in result)
            {
                Console.WriteLine($"{item.City}, {item.Count}, {item.AvgRent}, {item.MostType}, {item.ElevatorRatio}");
            }

            //第 20 題
            //我想找出「CP 值異常高」的物件：定義為同一城市、同一房屋類型中，租金低於該組平均租金 20 % 以上的物件。請列出這些物件，並標註它們比所屬分組平均便宜了多少錢。
            Console.ReadLine();
        }
    }
}
