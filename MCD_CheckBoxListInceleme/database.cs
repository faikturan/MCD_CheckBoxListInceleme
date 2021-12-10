using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_CheckBoxListInceleme
{
    public class database
    {
        public static List<urun> UrunTablo = new List<urun>()
        {
            new urun()
            {
                id = 1,
                urunAdi = "İz Bıraktığın Kadar Varsın",
                stokAdet = 10,
                urunKategori = "Roman",
                aciklama =@"NE KADAR İZ BIRAKIRSANIZ O KADAR VAZGEÇİLMEZ OLURSUNUZ.Kusursuz bir bütün için harikulade parçalar gerekir. Tıkır tıkır işleyen bir sistem ancak böyle yürür, bir kovandaki arıları ya da devasa bir karınca yuvasını düşünün. İlişkiler de böyledir, hiçbir şey tek başına tüm ilişkiyi ayakta tutmaya yetmez. Fırtınaya yakalanmış bir tekneye yelkenler tek başına yardımcı olamaz, sağlam bir motor, belki devreye girmesi gereken kürekler ve güvertede teknenin seyrini sağlayan hünerli birkaç insan lazımdır.",
                yazar ="Esra Ezmeci",
                urunResim =@"C:\Users\PC\Desktop\kitapResim\1.jpg"
            },
            new urun()
            {
                id = 2,
                urunAdi = "Kehribar Geçidi",
                stokAdet = 10,
                urunKategori = "Roman",
                aciklama =@"NE KADAR İZ BIRAKIRSANIZ O KADAR VAZGEÇİLMEZ OLURSUNUZ.Kusursuz bir bütün için harikulade parçalar gerekir. Tıkır tıkır işleyen bir sistem ancak böyle yürür, bir kovandaki arıları ya da devasa bir karınca yuvasını düşünün. İlişkiler de böyledir, hiçbir şey tek başına tüm ilişkiyi ayakta tutmaya yetmez. Fırtınaya yakalanmış bir tekneye yelkenler tek başına yardımcı olamaz, sağlam bir motor, belki devreye girmesi gereken kürekler ve güvertede teknenin seyrini sağlayan hünerli birkaç insan lazımdır.",
                yazar ="Nazan Bekiroğlu",
                urunResim =@"C:\Users\PC\Desktop\kitapResim\2.jpg"
            },
            new urun()
            {
                id = 3,
                urunAdi = "Taksiii",
                stokAdet = 10,
                urunKategori = "Roman",
                aciklama =@"NE KADAR İZ BIRAKIRSANIZ O KADAR VAZGEÇİLMEZ OLURSUNUZ.Kusursuz bir bütün için harikulade parçalar gerekir. Tıkır tıkır işleyen bir sistem ancak böyle yürür, bir kovandaki arıları ya da devasa bir karınca yuvasını düşünün. İlişkiler de böyledir, hiçbir şey tek başına tüm ilişkiyi ayakta tutmaya yetmez. Fırtınaya yakalanmış bir tekneye yelkenler tek başına yardımcı olamaz, sağlam bir motor, belki devreye girmesi gereken kürekler ve güvertede teknenin seyrini sağlayan hünerli birkaç insan lazımdır.",
                yazar ="Ayşe Kulin",
                urunResim =@"C:\Users\PC\Desktop\kitapResim\3.jpg"
            }
        };

    }
}