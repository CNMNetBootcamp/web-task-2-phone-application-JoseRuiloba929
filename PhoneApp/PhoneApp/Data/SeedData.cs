using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PhoneApp.Models;
using System;
using System.Linq;

namespace PhoneApp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PhoneAppContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<PhoneAppContext>>()))
            {
                // Look for any movies.
                if (context.Phone.Any())
                {
                    return;   // DB has been seeded
                }

                context.Phone.AddRange(
                 new Phone
                 {
                    Brand = "Samsung",
                    Name = "Galaxy Note 9",
                    batteryLife = 97,
                    LaunchDate = 2018,
                    phoneWeight = 201.0M,
                    phoneOS = "Android 8.1 Oreo",
                    phoneCPU = "Qualcomm Snapdragon 845 2.35 GHz quad-core",
                    phoneDisplay = "6.4 inch, 2960x1440-pixel resolution Super AMOLED",
                    phoneRating = 4.7M,
                    phoneImage = "xx"
                 },

                 new Phone
                 {
                    Brand = "Samsung",
                    Name = "Galaxy S9",
                    batteryLife = 78,
                    LaunchDate = 2018,
                    phoneWeight = 163.0M,
                    phoneOS = "Android 8.1 Oreo",
                    phoneCPU = "Snapdragon 660",
                    phoneDisplay = "6.3 Super AMOLED FullHD + 2220x1080px resolution Infinity display",
                    phoneRating = 4.7M,
                    phoneImage = "xx"
                 },

                 new Phone
                 {
                    Brand = "Asus",
                    Name = "ROG ",
                    batteryLife = 78,
                    LaunchDate = 2018,
                    phoneWeight = 200.0M,
                    phoneOS = "Android 8.1 Oreo",
                    phoneCPU = "Qualcomm SDM845 Snapdragon 845",
                    phoneDisplay = "6.0 inch, 1080x2160-pixel resolution Super AMOLED",
                    phoneRating = 4.1M,
                    phoneImage = "xx"
                 },

                new Phone
                {
                    Brand = "Asus",
                    Name = "Zenpad Z8s ZT582KL",
                    batteryLife = 13,
                    LaunchDate = 2017,
                    phoneWeight = 306.0M,
                    phoneOS = "Android 7.0 (Nougat)",
                    phoneCPU = "Qualcomm MSM8976 Snapdragon 652",
                    phoneDisplay = "",
                    phoneRating = 4.0M,
                    phoneImage = "xx"
                },

                new Phone
                {
                    Brand = "Apple",
                    Name = "iphone 8 Plus",
                    batteryLife = 81,
                    LaunchDate = 2017,
                    phoneWeight = 202.0M,
                    phoneOS = "OS11",
                    phoneCPU = "Apple A11 Bionic",
                    phoneDisplay = "LED-backlit IPS LCD, capacitive touchscreen, 16M colors",
                    phoneRating = 4.4M,
                    phoneImage = "xx"
                },

                new Phone
                {
                    Brand = "Apple",
                    Name = "iphone 7",
                    batteryLife = 61,
                    LaunchDate = 2016,
                    phoneWeight = 138.0M,
                    phoneOS = "iOS 10.0.1",
                    phoneCPU = "Apple A10 Fusion",
                    phoneDisplay = "LED-backlit IPS LCD, capacitive touchscreen, 16M colors",
                    phoneRating = 4.1M,
                    phoneImage = "xx"
                },

                new Phone
                {
                    Brand = "Google",
                    Name = "Pixel 3",
                    batteryLife = 69,
                    LaunchDate = 2018,
                    phoneWeight = 148.0M,
                    phoneOS = "Android 9.0 (Pie)",
                    phoneCPU = "Qualcomm SDM845 Snapdragon 845 ",
                    phoneDisplay = "P-OLED capacitive touchscreen, 16M colors",
                    phoneRating = 4.2M,
                    phoneImage = "xx"
                },

                new Phone
                {
                    Brand = "Google",
                    Name = "Pixel 3 Plus",
                    batteryLife = 32,
                    LaunchDate = 2018,
                    phoneWeight = 184.0M,
                    phoneOS = "Android 9.0 (Pie)",
                    phoneCPU = "Qualcomm SDM845 Snapdragon 845 ",
                    phoneDisplay = "P-OLED capacitive touchscreen, 16M colors",
                    phoneRating = 3.5M,
                    phoneImage = "xx"
                },

                new Phone
                {
                    Brand = "Acer",
                    Name = "Predator 8",
                    batteryLife = 9,
                    LaunchDate = 2015,
                    phoneWeight = 353.8M,
                    phoneOS = "Android 5.0 (Lollipop)",
                    phoneCPU = "Quad-core 1.6 GHz",
                    phoneDisplay = "",
                    phoneRating = 3.5M,
                    phoneImage = "xx"
                },

                new Phone
                {
                    Brand = "Acer",
                    Name = "Liquid Z520",
                    batteryLife = 9,
                    LaunchDate = 2015,
                    phoneWeight = 118.0M,
                    phoneOS = "Android 4.4.2 (KitKat)",
                    phoneCPU = "Quad-core 1.6 GHz",
                    phoneDisplay = "TFT capacitive touchscreen",
                    phoneRating = 3.0M,
                    phoneImage = "xx"
                },

                new Phone
                {
                    Brand = "Microsoft ",
                    Name = "Lumia 950 XL",
                    batteryLife  = 62,
                    LaunchDate = 2015,
                    phoneWeight = 165.0M,
                    phoneOS = "Microsoft Windows 10",
                    phoneCPU = "Qualcomm MSM8994 Snapdragon 810 ",
                    phoneDisplay = "AMOLED capacitive touchscreen, 16M colors",
                    phoneRating = 3.0M,
                    phoneImage = "xx"
                }
                );
                context.SaveChanges();
            }
        }
    }
}