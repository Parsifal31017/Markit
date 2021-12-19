using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Markit.Data;
using System;
using System.Linq;

namespace Markit.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MarkitContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MarkitContext>>()))
            {
                if (context.Markit.Any())
                {
                    return;
                }

                context.Markit.AddRange(
                    new Markit
                    {
                        Author = "Arthur Conan Doyle",
                        ReleaseDate = DateTime.Parse("2021-1-17"),
                        Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin at viverra risus. Duis tellus dolor, ultricies eu gravida vitae, feugiat eget velit. Nam dignissim ullamcorper vestibulum. Duis scelerisque consequat sagittis. Vestibulum at porttitor felis. Cras in blandit sem. Donec rutrum lorem dolor, ut pharetra eros luctus ut. Integer sodales justo sed tortor consectetur, id bibendum leo ornare. Curabitur eu euismod quam. Praesent magna lorem, sagittis non lobortis ut, lacinia et dolor.",
                    },
                    
                    new Markit
                    {
                        Author = "J. K. Rowling",
                        ReleaseDate = DateTime.Parse("2021-2-12"),
                        Text = "Pellentesque ornare, mi sed laoreet consectetur, justo dui condimentum magna, non vestibulum metus dui ac nisl. Aenean hendrerit, leo sed iaculis vehicula, odio justo egestas elit, ac blandit sapien nisi et elit. Proin erat justo, consectetur id semper ut, euismod vel ligula. Vivamus quis maximus nulla, eget consectetur massa. Quisque porta tincidunt dui, ut porta lacus posuere at. Nullam non fermentum tortor. Mauris ultricies augue magna, id semper augue elementum non.",
                    },

                    new Markit
                    {
                        Author = "Erich Maria Remarque",
                        ReleaseDate = DateTime.Parse("2021-3-13"),
                        Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam vitae convallis tortor, sit amet pellentesque magna. Integer pellentesque leo a odio elementum tempor. Aliquam vel volutpat sem. Etiam quam elit, scelerisque non placerat id, fringilla at nisl. Proin luctus dictum lacus, aliquet ultrices sem. Vestibulum accumsan mauris sit amet pretium interdum. Interdum et malesuada fames ac ante ipsum primis in faucibus. Nullam vehicula lorem ut malesuada venenatis. Vestibulum nisl turpis, dapibus dictum velit eget, luctus rhoncus nunc.",
                    },

                    new Markit
                    {
                        Author = "Fyodor Dostoevsky",
                        ReleaseDate = DateTime.Parse("2021-4-19"),
                        Text = "Maecenas lacinia a velit at sagittis. Ut turpis leo, convallis vitae elementum vitae, egestas sit amet sapien. Praesent porta purus eu facilisis vehicula. Integer vel augue ut metus accumsan eleifend. Morbi tempor, odio at mattis fringilla, erat mi pharetra ex, sit amet molestie eros metus sed eros. Nunc varius leo non nunc molestie, a rhoncus neque dapibus. Sed eget mauris dictum, feugiat lacus eu, ultrices nibh.",
                    },

                    new Markit
                    {
                        Author = "Victor Hugo",
                        ReleaseDate = DateTime.Parse("2021-5-27"),
                        Text = "Fusce scelerisque arcu tortor. Pellentesque ipsum nisi, tincidunt eget euismod non, laoreet sit amet ligula. Ut vel purus eros. Etiam eget erat id libero maximus iaculis. Proin eu vehicula augue. Vestibulum rutrum, diam volutpat venenatis imperdiet, ipsum eros convallis est, ac tempus est felis in velit. Phasellus sed ante nibh. Mauris facilisis blandit leo vitae molestie. Nullam sit amet sollicitudin sem. Maecenas eu fringilla eros. Aenean arcu lacus, blandit bibendum rutrum at, condimentum in felis. Vivamus auctor accumsan ornare. Nam eu erat quis tellus volutpat aliquet eget nec ante. Integer non eleifend dolor.",
                    },

                    new Markit
                    {
                        Author = "Jules Verne",
                        ReleaseDate = DateTime.Parse("2021-6-11"),
                        Text = "Nulla accumsan leo at tincidunt efficitur. Mauris porttitor mi lectus, non imperdiet eros venenatis a. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Sed vestibulum nulla elementum nibh aliquam, eu imperdiet augue molestie. Quisque sed tincidunt nisi. Quisque auctor augue ac consequat facilisis. Aliquam id magna scelerisque ligula rutrum facilisis.",
                    },

                    new Markit
                    {
                        Author = "Mark Twain",
                        ReleaseDate = DateTime.Parse("2021-7-10"),
                        Text = "Maecenas condimentum efficitur massa, vitae iaculis erat pellentesque a. Phasellus sodales massa mauris, et ultrices nunc blandit id. Proin in turpis in metus facilisis placerat dapibus nec eros. Curabitur scelerisque, metus nec consequat malesuada, nibh nunc efficitur leo, non porta tellus lorem sed ipsum. In mattis, nisi sed faucibus ornare, lorem lectus dignissim dui, sed malesuada quam nibh sit amet elit. Nam facilisis sit amet nunc ac aliquam. Duis sollicitudin laoreet est eget congue. Aliquam posuere sapien nisl, ac dapibus lacus pretium vel. Vestibulum aliquet mauris nec tellus volutpat molestie. Nam a tellus in augue imperdiet lobortis. Mauris sollicitudin nisl ac malesuada varius. Aliquam lobortis hendrerit magna, ac congue enim commodo id. Vivamus condimentum pellentesque ligula et ullamcorper. Integer interdum, felis eget egestas placerat, turpis eros tempor elit, in cursus magna sapien nec nunc. Vivamus ultricies neque vel lorem hendrerit, sed pharetra justo varius. Aenean et consequat dolor.",
                    },

                    new Markit
                    {
                        Author = "William Shakespeare",
                        ReleaseDate = DateTime.Parse("2021-8-14"),
                        Text = "Etiam vehicula neque risus, eu dapibus metus facilisis quis. Fusce vitae fermentum purus. Aliquam condimentum faucibus erat in efficitur. Quisque vitae efficitur eros. Donec nisi eros, pretium ut scelerisque sit amet, dignissim id est. In eu nunc dignissim urna suscipit posuere et non est. Proin rutrum metus non purus iaculis, quis varius nibh ornare. Vestibulum elementum condimentum malesuada. Aliquam vulputate scelerisque semper. Ut turpis erat, cursus vitae tempus ac, venenatis vitae ipsum. Mauris luctus justo eu enim dictum bibendum. Donec sed dolor nec ante dapibus finibus. Donec facilisis augue nec purus faucibus pharetra.",
                    },

                    new Markit
                    {
                        Author = "Alexander Green",
                        ReleaseDate = DateTime.Parse("2021-9-15"),
                        Text = "Praesent luctus diam eu interdum maximus. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Morbi hendrerit vel nulla ac porta. Nunc tempus commodo massa sit amet euismod. Suspendisse vitae leo non diam consequat fermentum at a erat. Ut et pretium elit. Pellentesque lorem lacus, interdum eu molestie ut, elementum id tortor. Etiam tristique aliquam arcu congue tempor. Nullam aliquam pellentesque leo, ut ullamcorper erat sagittis finibus.",
                    },

                    new Markit
                    {
                        Author = "George Orwell",
                        ReleaseDate = DateTime.Parse("2021-10-25"),
                        Text = "Proin finibus lacinia dolor ut scelerisque. Pellentesque scelerisque velit eget diam pellentesque rhoncus. Praesent sagittis id libero eget mattis. Vivamus risus lectus, hendrerit sit amet dictum ac, aliquet eu nibh. Proin a lorem eu dui tempor tempus nec sit amet mi. In aliquet, nulla quis rutrum faucibus, justo orci porttitor ante, posuere facilisis odio augue sit amet quam. Sed et tellus arcu. Sed scelerisque pretium eleifend. Quisque tincidunt urna elit, sed suscipit turpis feugiat a. Vivamus ultrices risus ac ullamcorper sagittis.",
                    },

                    new Markit
                    {
                        Author = "Hermann Hesse",
                        ReleaseDate = DateTime.Parse("2021-11-29"),
                        Text = "Nullam eget elit tempor, ultrices massa a, sodales sem. Nunc in imperdiet sapien. Pellentesque vestibulum tortor a dui commodo, eget consectetur lorem tempor. Curabitur maximus pharetra purus, ac pulvinar purus auctor ac. Nulla et nisl felis. Nunc neque nisi, imperdiet sed lobortis dignissim, finibus et elit. Aenean vel urna eros. Suspendisse vel consequat elit. Praesent sollicitudin est ut sem laoreet, eu malesuada nisi imperdiet. Suspendisse in nibh placerat, condimentum purus vel, faucibus augue. In et auctor sapien. Morbi ac lobortis mauris. Nunc eleifend purus lectus. Ut non nisl enim. Etiam nec varius justo. Nam aliquam quam dui, quis ultricies nisl tristique quis.",
                    },

                    new Markit
                    {
                        Author = "Gabriel Garcia Marquez",
                        ReleaseDate = DateTime.Parse("2021-12-30"),
                        Text = "Nam nisl lectus, molestie aliquet iaculis quis, iaculis et dolor. Morbi non egestas purus. Vestibulum vulputate ac sapien ac ornare. Donec turpis mauris, vehicula quis dui vel, efficitur malesuada nibh. Curabitur libero ligula, laoreet ut turpis non, ultrices commodo erat. Nullam laoreet lacus risus, eu eleifend sem cursus fringilla. Ut mollis dapibus tellus, non consectetur erat venenatis ac. Donec sit amet aliquet nisl. Vivamus auctor justo nec ante placerat pulvinar. Curabitur accumsan, metus in porttitor ornare, magna ipsum iaculis metus, sit amet volutpat ipsum dui in ligula. Nulla facilisi. Interdum et malesuada fames ac ante ipsum primis in faucibus. Curabitur laoreet mi sed ipsum elementum, non aliquet erat ornare. Ut volutpat bibendum mauris aliquam ultrices. Pellentesque dictum in odio sed rutrum.",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
