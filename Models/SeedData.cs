using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;

namespace MusicBox.Models{
    public static class SeedData{
        public static void Initialize(IServiceProvider serviceProvider){
            using (var context = new ArtistDbContext(serviceProvider.GetRequiredService<DbContextOptions<ArtistDbContext>>())){
                if (context.Artist.Any())
                {
                    return;
                }
                context.Artist.AddRange(
                    new Artist{
                        ArtistName = "Taylor Swift",
                        Albums = new List<Album>{
                            new Album {Title="Taylor Swift"},
                            new Album {Title="Fearless"},
                            new Album {Title="Speak Now"},
                            new Album {Title="Red"},
                            new Album {Title="1989"},
                            new Album {Title="Reputation"},
                            new Album {Title="Lover"},
                            new Album {Title="folklore"},
                            new Album {Title="evermore"},
                        }
                    },
                    new Artist{
                        ArtistName="The Cure",
                        Albums = new List<Album>{
                            new Album {Title="Three Imaginary Boys"},
                            new Album {Title="Seventeen Seconds"},
                            new Album {Title="Faith"},
                            new Album {Title="Pgraphy"},
                            new Album {Title="The Head on the Door"},
                            new Album {Title="Kiss Me,Kiss Me,Kiss Me"},
                            new Album {Title="Disintergration"},
                            new Album {Title="Wish"},
                            new Album {Title="Wild Mood Swings"},
                            new Album {Title="Bloodflowers"},
                            new Album {Title="The Cure"},
                            new Album {Title="4:13 Dream"},
                        }
                    },
                    new Artist{
                        ArtistName = "The Smiths",
                        Albums = new List<Album>{
                            new Album {Title="The Smiths"},
                            new Album {Title="Louder Than Bombs"},
                            new Album {Title="Meat Is Murder"},
                            new Album {Title="The Queen Is Dead"},
                            new Album {Title="Strangeways, Here We Come"},
                        }
                    },
                    new Artist{
                        ArtistName = "Beach House",
                        Albums = new List<Album>{
                            new Album{Title="Devotion"},
                            new Album{Title="Depression Cherry"},
                            new Album{Title="Bloom"},
                            new Album{Title="Teen Dream"},
                            new Album{Title="Once Twice Melody"}
                        }

                    },
                    new Artist{
                        ArtistName = "Mitski",
                        Albums = new List<Album>{
                            new Album {Title="Lush"},
                            new Album{Title="Bury Me at Makeout Creek"},
                            new Album{Title="Puberty 2"},
                            new Album{Title="Be the Cowboy"},
                            new Album{Title="Laurel Hell"}
                        }
                    },
                    new Artist{
                        ArtistName = "My Bloody Valentine",
                        Albums = new List<Album>{
                            new Album{Title="Isnt Anything"},
                            new Album{Title="Loveless"},
                            new Album{Title="mbv"}
                        }                  
                    }
                );
                context.SaveChanges();
            }

        }
    }
}