using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public class Weather
    {
  //      "result":{
		//"sk":{
		//	"temp":"6",
		//	"wind_direction":"北风",
		//	"wind_strength":"3级",
		//	"humidity":"99%",
		//	"time":"08:39"
		//},
		//"today":{
		//	"temperature":"8℃~10℃",
		//	"weather":"小雨-中雨转阴",
		//	"weather_id":{
		//		"fa":"21",
		//		"fb":"02"
		//	},
		//	"wind":"北风微风",
		//	"week":"星期五",
		//	"city":"柳州",
		//	"date_y":"2019年01月11日",
		//	"dressing_index":"较冷",
		//	"dressing_advice":"建议着厚外套加毛衣等服装。年老体弱者宜着大衣、呢外套加羊毛衫。",
		//	"uv_index":"最弱",
		//	"comfort_index":"",
		//	"wash_index":"不宜",
		//	"travel_index":"较不宜",
		//	"exercise_index":"较不宜",
		//	"drying_index":""
		//}
        [DisplayName("温度")]
        //	result/today "temperature":"8℃~10℃",
        public string Temperature { get; set; }
        [DisplayName("城市")]
        public string City { get; set; }
        //  result/today "city":"柳州",
        [DisplayName("湿度")]
        //	"humidity":"99%",
        public string Humidity { get; set; }

    }
}