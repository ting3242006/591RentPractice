using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _591RentPractice
{
    public class RentalListing
    {
        public string LocationCity { get; set; }       // 城市,例如:桃園市
        public string LocationDistrict { get; set; }   // 區,例如:中壢區、楊梅區
        public string Type { get; set; }               // 類型:整層住家 / 獨立套房 / 分租套房 / 雅房
        public int Rent { get; set; }                  // 租金(元)
        public int Rooms { get; set; }                 // 房間數
        public int Bathrooms { get; set; }             // 衛浴數
        public bool IsNearMRT { get; set; }            // 是否近捷運
        public bool IsNewlyListed { get; set; }        // 是否新上架
        public bool AllowsPets { get; set; }           // 可養寵物
        public bool ShortTermRent { get; set; }        // 可短期租賃
        public string BuildingType { get; set; }       // 型態:公寓 / 電梯大樓 / 透天厝 / 別墅
        public double SizePing { get; set; }           // 坪數
        public int Floor { get; set; }                 // 樓層
        public int TotalFloors { get; set; }           // 總樓層數
        public bool HasAC { get; set; }                // 有冷氣
        public bool HasWasher { get; set; }            // 有洗衣機
        public bool HasFridge { get; set; }            // 有冰箱
        public bool HasWaterHeater { get; set; }       // 有熱水器
        public bool HasGas { get; set; }               // 有天然瓦斯
        public bool HasInternet { get; set; }          // 有網路
        public bool HasBed { get; set; }               // 有床
        public bool HasParking { get; set; }           // 有車位
        public bool HasElevator { get; set; }          // 有電梯
        public bool HasBalcony { get; set; }           // 有陽台
    }
}
