using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ElliotDvp_tarea04.Models;

namespace ElliotDvp_tarea04.Controllers;

public class ListaController : Controller
    {
        private static List<Lista> perros = Enumerable.Range(1, 100).Select(i => new Lista
        {
            Nombre = $"Perro {i}",
            Peso = $"{10 + (i % 20)} kg",
            Tamano = (i % 2 == 0) ? "Grande" : "Pequeño",
            Edad = $"{2 + (i % 10)} años",
            Descripcion = $"Descripción del perro {i}.",
            Categoria = (i % 5) switch{
                    0 => "Perros pequeños",
                    1 => "Perros familiares",
                    2 => "Perros raros",
                    3 => "Perros guardianes",
                    _ => "Perros para apartamento"
                }
            }).ToList();

         public IActionResult Index()
    {
        var perros = new List<Lista>
        {
        new Lista { Nombre = "Airedale Terrier", Peso = "20 kg", Tamano = "Mediano", Edad = "8 años", Descripcion = "Terrier inglés activo y valiente.", ImagenUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ7WAOUY0HUOG_ZZnViGcCeNfEf79psMFxdEQ&s", Categoria = "Perros guardianes" },
        new Lista { Nombre = "Akita Inu", Peso = "35 kg", Tamano = "Grande", Edad = "10 años", Descripcion = "Leal y protector, originario de Japón.", ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/70/Akita_Inu_%28male%29.jpg/1200px-Akita_Inu_%28male%29.jpg", Categoria = "Perros guardianes" },
        new Lista { Nombre = "Alaskan Malamute", Peso = "38 kg", Tamano = "Grande", Edad = "9 años", Descripcion = "Fuerte perro de trineo del Ártico.", ImagenUrl = "https://s3.amazonaws.com/cdn-origin-etr.akc.org/wp-content/uploads/2017/11/09151144/Alaskan-Malamute-standing-in-the-grass1.jpg", Categoria = "Perros familiares" },
        new Lista { Nombre = "American Bully", Peso = "30 kg", Tamano = "Mediano", Edad = "8 años", Descripcion = "Musculoso y cariñoso.", ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/63/Champion_Charlie_Muscles_%282%29.jpg/960px-Champion_Charlie_Muscles_%282%29.jpg", Categoria = "Perros familiares" },
        new Lista { Nombre = "American Pit Bull Terrier", Peso = "27 kg", Tamano = "Mediano", Edad = "9 años", Descripcion = "Ágil y energético.", ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/b/b0/001_American_Pit_Bull_Terrier.jpg", Categoria = "Perros guardianes" },
        new Lista { Nombre = "Basenji", Peso = "10 kg", Tamano = "Pequeño", Edad = "12 años", Descripcion = "Perro africano que no ladra.", ImagenUrl = "https://eyracan.com/wp-content/uploads/2023/10/raza-de-perro-basenji.jpg", Categoria = "Perros raros" },
        new Lista { Nombre = "Beagle", Peso = "11 kg", Tamano = "Pequeño", Edad = "13 años", Descripcion = "Sociable y amigable.", ImagenUrl = "https://cdn.britannica.com/16/234216-050-C66F8665/beagle-hound-dog.jpg", Categoria = "Perros familiares" },
        new Lista { Nombre = "Bichón Frisé", Peso = "6 kg", Tamano = "Pequeño", Edad = "14 años", Descripcion = "Blanco y esponjoso.", ImagenUrl = "https://cloudfront-us-east-1.images.arcpublishing.com/infobae/UEWI2YAQABEUFBDT67HEHTCH6M.jpg", Categoria = "Perros para apartamento" },
        new Lista { Nombre = "Bloodhound", Peso = "36 kg", Tamano = "Grande", Edad = "10 años", Descripcion = "Experto rastreador.", ImagenUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQzA39ASfSfgsw_LmH2yuTM7qZm2PM4cu0obw&s", Categoria = "Perros guardianes" },
        new Lista { Nombre = "Bobtail", Peso = "32 kg", Tamano = "Grande", Edad = "12 años", Descripcion = "Pastor inglés de pelo largo.", ImagenUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTM0L7MpKE5C4m4PKi2ly1UKW62HlSteqQt_w&s", Categoria = "Perros familiares" },
        new Lista { Nombre = "Border Collie", Peso = "20 kg", Tamano = "Mediano", Edad = "12 años", Descripcion = "El perro más inteligente del mundo.", ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1f/Border_collie_canon.jpg/330px-Border_collie_canon.jpg", Categoria = "Perros familiares" },
        new Lista { Nombre = "Boston Terrier", Peso = "7 kg", Tamano = "Pequeño", Edad = "13 años", Descripcion = "Americano de carácter alegre.", ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/6/66/BostonTerrierBrindleStand_w.jpg", Categoria = "Perros pequeños" },
        new Lista { Nombre = "Boxer", Peso = "30 kg", Tamano = "Grande", Edad = "10 años", Descripcion = "Energético y juguetón.", ImagenUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRfcNEk_AYJ1ZGbC_SRLsmXvWnnD376hlzwuA&s", Categoria = "Perros guardianes" },
        new Lista { Nombre = "Bulldog Francés", Peso = "12 kg", Tamano = "Pequeño", Edad = "10 años", Descripcion = "Cariñoso y de orejas de murciélago.", ImagenUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSC_H4rfKaC2zOvT0a0MfYk9Lr0QYQyKaIuVg&s", Categoria = "Perros para apartamento" },
        new Lista { Nombre = "Bulldog Inglés", Peso = "25 kg", Tamano = "Mediano", Edad = "8 años", Descripcion = "Tierno y tranquilo.", ImagenUrl = "https://www.zooplus.es/magazine/wp-content/uploads/2017/10/fotolia_58776564.webp", Categoria = "Perros familiares" },
        new Lista { Nombre = "Bullmastiff", Peso = "50 kg", Tamano = "Grande", Edad = "9 años", Descripcion = "Protector y valiente.", ImagenUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT1cIr6s-8D3Loc9lkF9HS_KPRjSouF9osYVQ&s", Categoria = "Perros guardianes" },
        new Lista { Nombre = "Cairn Terrier", Peso = "6 kg", Tamano = "Pequeño", Edad = "14 años", Descripcion = "Valiente y alerta.", ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b0/Cairn-Terrier-Garten1.jpg/1200px-Cairn-Terrier-Garten1.jpg", Categoria = "Perros pequeños" },
        new Lista { Nombre = "Caniche Toy", Peso = "4 kg", Tamano = "Pequeño", Edad = "14 años", Descripcion = "Inteligente y elegante.", ImagenUrl = "https://cdn.shopify.com/s/files/1/0648/0124/3361/files/iStock-1380984414.jpg?v=1741704029", Categoria = "Perros para apartamento" },
        new Lista { Nombre = "Carlino", Peso = "8 kg", Tamano = "Pequeño", Edad = "13 años", Descripcion = "Cariñoso y de expresión dulce.", ImagenUrl = "https://www.purina.es/sites/default/files/styles/ttt_image_510/public/2024-02/sitesdefaultfilesstylessquare_medium_440x440public2022-08Pug.jpg?itok=6_9mk7Br", Categoria = "Perros pequeños" },
        new Lista { Nombre = "Chihuahua", Peso = "3 kg", Tamano = "Pequeño", Edad = "15 años", Descripcion = "El perro más pequeño del mundo.", ImagenUrl = "https://cdn.britannica.com/44/233244-050-A65D4571/Chihuahua-dog.jpg", Categoria = "Perros para apartamento" },
        new Lista { Nombre = "Chow Chow", Peso = "25 kg", Tamano = "Mediano", Edad = "11 años", Descripcion = "De lengua azul y carácter independiente.", ImagenUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQAYGKNyQ2vtsETXh6fnQ1OcmTULmCi4BfbGQ&s", Categoria = "Perros raros" },
        new Lista { Nombre = "Cocker Spaniel", Peso = "13 kg", Tamano = "Mediano", Edad = "12 años", Descripcion = "Alegre y de orejas largas.", ImagenUrl = "https://example.com/cocker.jpg", Categoria = "Perros familiares" },
        new Lista { Nombre = "Collie", Peso = "25 kg", Tamano = "Grande", Edad = "12 años", Descripcion = "Elegante y leal.", ImagenUrl = "https://example.com/collie.jpg", Categoria = "Perros familiares" },
        new Lista { Nombre = "Dálmata", Peso = "25 kg", Tamano = "Mediano", Edad = "12 años", Descripcion = "Famoso por sus manchas.", ImagenUrl = "https://example.com/dalmatian.jpg", Categoria = "Perros familiares" },
        new Lista { Nombre = "Doberman", Peso = "35 kg", Tamano = "Grande", Edad = "10 años", Descripcion = "Ágil y protector.", ImagenUrl = "https://example.com/doberman.jpg", Categoria = "Perros guardianes" },
        new Lista { Nombre = "Dogo Argentino", Peso = "45 kg", Tamano = "Grande", Edad = "10 años", Descripcion = "Fuerte y valiente.", ImagenUrl = "https://example.com/dogo.jpg", Categoria = "Perros guardianes" },
        new Lista { Nombre = "Fox Terrier", Peso = "8 kg", Tamano = "Pequeño", Edad = "13 años", Descripcion = "Energético y curioso.", ImagenUrl = "https://example.com/foxterrier.jpg", Categoria = "Perros pequeños" },
        new Lista { Nombre = "Golden Retriever", Peso = "32 kg", Tamano = "Grande", Edad = "11 años", Descripcion = "Amigable y paciente.", ImagenUrl = "https://example.com/golden.jpg", Categoria = "Perros familiares" },
        new Lista { Nombre = "Gran Danés", Peso = "70 kg", Tamano = "Gigante", Edad = "7 años", Descripcion = "El Apolo de los perros.", ImagenUrl = "https://example.com/greatdane.jpg", Categoria = "Perros guardianes" },
        new Lista { Nombre = "Husky Siberiano", Peso = "25 kg", Tamano = "Mediano", Edad = "12 años", Descripcion = "De ojos azules y espíritu libre.", ImagenUrl = "https://example.com/husky.jpg", Categoria = "Perros familiares" },
        new Lista { Nombre = "Jack Russell Terrier", Peso = "6 kg", Tamano = "Pequeño", Edad = "14 años", Descripcion = "Energético y valiente.", ImagenUrl = "https://example.com/jackrussell.jpg", Categoria = "Perros pequeños" },
        new Lista { Nombre = "Labrador Retriever", Peso = "30 kg", Tamano = "Grande", Edad = "12 años", Descripcion = "El perro más popular del mundo.", ImagenUrl = "https://example.com/labrador.jpg", Categoria = "Perros familiares" },
        new Lista { Nombre = "Lhasa Apso", Peso = "7 kg", Tamano = "Pequeño", Edad = "14 años", Descripcion = "Tibetano de pelo largo.", ImagenUrl = "https://example.com/lhasa.jpg", Categoria = "Perros pequeños" },
        new Lista { Nombre = "Papillón", Peso = "4 kg", Tamano = "Pequeño", Edad = "15 años", Descripcion = "Elegante y afectuoso.", ImagenUrl = "https://example.com/papillon.jpg", Categoria = "Perros para apartamento" },
        new Lista { Nombre = "Mastín Español", Peso = "60 kg", Tamano = "Gigante", Edad = "10 años", Descripcion = "Poderoso y tranquilo.", ImagenUrl = "https://example.com/mastin.jpg", Categoria = "Perros guardianes" },
        new Lista { Nombre = "Pastor Alemán", Peso = "35 kg", Tamano = "Grande", Edad = "11 años", Descripcion = "Inteligente y versátil.", ImagenUrl = "https://example.com/germanshepherd.jpg", Categoria = "Perros guardianes" },
        new Lista { Nombre = "Pequinés", Peso = "5 kg", Tamano = "Pequeño", Edad = "13 años", Descripcion = "Pequeño y valiente.", ImagenUrl = "https://example.com/pekingese.jpg", Categoria = "Perros pequeños" },
        new Lista { Nombre = "Pomerania", Peso = "3 kg", Tamano = "Pequeño", Edad = "14 años", Descripcion = "Pequeño y esponjoso.", ImagenUrl = "https://example.com/pomeranian.jpg", Categoria = "Perros para apartamento" },
        new Lista { Nombre = "Pug", Peso = "8 kg", Tamano = "Pequeño", Edad = "13 años", Descripcion = "Cariñoso y de expresión dulce.", ImagenUrl = "https://example.com/pug.jpg", Categoria = "Perros pequeños" },
        new Lista { Nombre = "Rottweiler", Peso = "45 kg", Tamano = "Grande", Edad = "10 años", Descripcion = "Protector y leal.", ImagenUrl = "https://example.com/rottweiler.jpg", Categoria = "Perros guardianes" },
        new Lista { Nombre = "San Bernardo", Peso = "80 kg", Tamano = "Gigante", Edad = "8 años", Descripcion = "Rescatador alpino.", ImagenUrl = "https://example.com/saintbernard.jpg", Categoria = "Perros familiares" },
        new Lista { Nombre = "Schnauzer Miniatura", Peso = "7 kg", Tamano = "Pequeño", Edad = "14 años", Descripcion = "Inteligente y alerta.", ImagenUrl = "https://example.com/schnauzer.jpg", Categoria = "Perros pequeños" },
        new Lista { Nombre = "Shar Pei", Peso = "22 kg", Tamano = "Mediano", Edad = "10 años", Descripcion = "De piel arrugada.", ImagenUrl = "https://example.com/sharpei.jpg", Categoria = "Perros raros" },
        new Lista { Nombre = "Shiba Inu", Peso = "10 kg", Tamano = "Pequeño", Edad = "14 años", Descripcion = "Japonés de carácter independiente.", ImagenUrl = "https://example.com/shiba.jpg", Categoria = "Perros pequeños" },
        new Lista { Nombre = "Shih Tzu", Peso = "6 kg", Tamano = "Pequeño", Edad = "14 años", Descripcion = "Cariñoso y de pelo largo.", ImagenUrl = "https://example.com/shihtzu.jpg", Categoria = "Perros para apartamento" },
        new Lista { Nombre = "Terranova", Peso = "60 kg", Tamano = "Gigante", Edad = "9 años", Descripcion = "Excelente nadador.", ImagenUrl = "https://example.com/newfoundland.jpg", Categoria = "Perros familiares" },
        new Lista { Nombre = "West Highland White Terrier", Peso = "8 kg", Tamano = "Pequeño", Edad = "14 años", Descripcion = "Blanco y alegre.", ImagenUrl = "https://example.com/westie.jpg", Categoria = "Perros pequeños" },
        new Lista { Nombre = "Yorkshire Terrier", Peso = "3 kg", Tamano = "Pequeño", Edad = "14 años", Descripcion = "Pequeño y valiente.", ImagenUrl = "https://example.com/yorkie.jpg", Categoria = "Perros para apartamento" },
        new Lista { Nombre = "Affenpinscher", Peso = "4 kg", Tamano = "Pequeño", Edad = "12 años", Descripcion = "Pequeño y de expresión simiesca.", ImagenUrl = "https://example.com/affenpinscher.jpg", Categoria = "Perros pequeños" },
        new Lista { Nombre = "Afghan Hound", Peso = "27 kg", Tamano = "Grande", Edad = "12 años", Descripcion = "Elegante y de pelo largo.", ImagenUrl = "https://example.com/afghan.jpg", Categoria = "Perros raros" },
        new Lista { Nombre = "Aidi", Peso = "25 kg", Tamano = "Mediano", Edad = "11 años", Descripcion = "Perro de montaña marroquí.", ImagenUrl = "https://example.com/aidi.jpg", Categoria = "Perros guardianes" },
        new Lista { Nombre = "Azawakh", Peso = "20 kg", Tamano = "Grande", Edad = "12 años", Descripcion = "Lebrel africano esbelto.", ImagenUrl = "https://example.com/azawakh.jpg", Categoria = "Perros raros" },
        new Lista { Nombre = "Beauceron", Peso = "35 kg", Tamano = "Grande", Edad = "11 años", Descripcion = "Pastor francés inteligente.", ImagenUrl = "https://example.com/beauceron.jpg", Categoria = "Perros guardianes" },
        new Lista { Nombre = "Bedlington Terrier", Peso = "10 kg", Tamano = "Pequeño", Edad = "14 años", Descripcion = "Parecido a un cordero.", ImagenUrl = "https://example.com/bedlington.jpg", Categoria = "Perros pequeños" },
        new Lista { Nombre = "Bergamasco", Peso = "32 kg", Tamano = "Mediano", Edad = "13 años", Descripcion = "De pelo en rastas.", ImagenUrl = "https://example.com/bergamasco.jpg", Categoria = "Perros raros" },
        new Lista { Nombre = "Bichón Maltés", Peso = "4 kg", Tamano = "Pequeño", Edad = "15 años", Descripcion = "Blanco y sedoso.", ImagenUrl = "https://example.com/maltese.jpg", Categoria = "Perros para apartamento" },
        new Lista { Nombre = "Borzoi", Peso = "40 kg", Tamano = "Grande", Edad = "10 años", Descripcion = "Lebrel ruso aristocrático.", ImagenUrl = "https://example.com/borzoi.jpg", Categoria = "Perros raros" },
        new Lista { Nombre = "Boyero de Berna", Peso = "45 kg", Tamano = "Grande", Edad = "8 años", Descripcion = "Tricolor suizo.", ImagenUrl = "https://example.com/berner.jpg", Categoria = "Perros familiares" },
        new Lista { Nombre = "Braco Alemán", Peso = "30 kg", Tamano = "Grande", Edad = "12 años", Descripcion = "Excelente perro de caza.", ImagenUrl = "https://example.com/germanpointer.jpg", Categoria = "Perros familiares" },
        new Lista { Nombre = "Braco de Weimar", Peso = "35 kg", Tamano = "Grande", Edad = "11 años", Descripcion = "Elegante y de color gris.", ImagenUrl = "https://example.com/weimaraner.jpg", Categoria = "Perros familiares" },
        new Lista { Nombre = "Bull Terrier", Peso = "28 kg", Tamano = "Mediano", Edad = "12 años", Descripcion = "De cabeza ovalada característica.", ImagenUrl = "https://example.com/bullterrier.jpg", Categoria = "Perros guardianes" },
        new Lista { Nombre = "Cane Corso", Peso = "45 kg", Tamano = "Grande", Edad = "10 años", Descripcion = "Moloso italiano poderoso.", ImagenUrl = "https://example.com/canecorso.jpg", Categoria = "Perros guardianes" },
        new Lista { Nombre = "Chesapeake Bay Retriever", Peso = "32 kg", Tamano = "Grande", Edad = "11 años", Descripcion = "Amante del agua.", ImagenUrl = "https://example.com/chesapeake.jpg", Categoria = "Perros familiares" },
        new Lista { Nombre = "Crestado Chino", Peso = "5 kg", Tamano = "Pequeño", Edad = "13 años", Descripcion = "Con o sin pelo.", ImagenUrl = "https://example.com/crested.jpg", Categoria = "Perros raros" },
        new Lista { Nombre = "Dogo de Burdeos", Peso = "50 kg", Tamano = "Grande", Edad = "9 años", Descripcion = "Moloso francés musculoso.", ImagenUrl = "https://example.com/dogodeburdeos.jpg", Categoria = "Perros guardianes" },
        new Lista { Nombre = "Elkhound Noruego", Peso = "22 kg", Tamano = "Mediano", Edad = "12 años", Descripcion = "Perro vikingo resistente.", ImagenUrl = "https://example.com/elkhound.jpg", Categoria = "Perros familiares" },
        new Lista { Nombre = "Galgo Español", Peso = "30 kg", Tamano = "Grande", Edad = "12 años", Descripcion = "Lebrel español veloz.", ImagenUrl = "https://example.com/galgo.jpg", Categoria = "Perros raros" },
        new Lista { Nombre = "Irish Wolfhound", Peso = "55 kg", Tamano = "Gigante", Edad = "7 años", Descripcion = "El perro más alto.", ImagenUrl = "https://example.com/irishwolfhound.jpg", Categoria = "Perros familiares" },
        new Lista { Nombre = "Keeshond", Peso = "18 kg", Tamano = "Mediano", Edad = "13 años", Descripcion = "Esponjoso y simpático.", ImagenUrl = "https://example.com/keeshond.jpg", Categoria = "Perros familiares" },
        new Lista { Nombre = "Kerry Blue Terrier", Peso = "18 kg", Tamano = "Mediano", Edad = "13 años", Descripcion = "De pelaje azulado.", ImagenUrl = "https://example.com/kerryblue.jpg", Categoria = "Perros pequeños" },
        new Lista { Nombre = "Komondor", Peso = "50 kg", Tamano = "Grande", Edad = "10 años", Descripcion = "Parecido a una fregona.", ImagenUrl = "https://example.com/komondor.jpg", Categoria = "Perros guardianes" },
        new Lista { Nombre = "Kuvasz", Peso = "45 kg", Tamano = "Grande", Edad = "10 años", Descripcion = "Pastor húngaro blanco.", ImagenUrl = "https://example.com/kuvasz.jpg", Categoria = "Perros guardianes" },
        new Lista { Nombre = "Leonberger", Peso = "65 kg", Tamano = "Gigante", Edad = "8 años", Descripcion = "Gentil gigante alemán.", ImagenUrl = "https://example.com/leonberger.jpg", Categoria = "Perros familiares" },
        new Lista { Nombre = "Löwchen", Peso = "5 kg", Tamano = "Pequeño", Edad = "14 años", Descripcion = "Pequeño león.", ImagenUrl = "https://example.com/lowchen.jpg", Categoria = "Perros para apartamento" },
        new Lista { Nombre = "Perro de Agua Español", Peso = "20 kg", Tamano = "Mediano", Edad = "12 años", Descripcion = "De pelo rizado.", ImagenUrl = "https://example.com/spanishwaterdog.jpg", Categoria = "Perros familiares" },
        new Lista { Nombre = "Perro sin Pelo del Perú", Peso = "12 kg", Tamano = "Mediano", Edad = "13 años", Descripcion = "Sin pelo y elegante.", ImagenUrl = "https://example.com/peruvianhairless.jpg", Categoria = "Perros raros" },
        new Lista { Nombre = "Pharaoh Hound", Peso = "20 kg", Tamano = "Mediano", Edad = "12 años", Descripcion = "Lebrel maltés antiguo.", ImagenUrl = "https://example.com/pharaoh.jpg", Categoria = "Perros raros" },
        new Lista { Nombre = "Pointer", Peso = "25 kg", Tamano = "Grande", Edad = "12 años", Descripcion = "Elegante perro de caza.", ImagenUrl = "https://example.com/pointer.jpg", Categoria = "Perros familiares" },
        new Lista { Nombre = "Presa Canario", Peso = "50 kg", Tamano = "Grande", Edad = "10 años", Descripcion = "Moloso de las Islas Canarias.", ImagenUrl = "https://example.com/presacanario.jpg", Categoria = "Perros guardianes" },
        new Lista { Nombre = "Pudelpointer", Peso = "30 kg", Tamano = "Grande", Edad = "12 años", Descripcion = "Cruza de caniche y pointer.", ImagenUrl = "https://example.com/pudelpointer.jpg", Categoria = "Perros familiares" },
        new Lista { Nombre = "Rhodesian Ridgeback", Peso = "36 kg", Tamano = "Grande", Edad = "10 años", Descripcion = "Con cresta en la espalda.", ImagenUrl = "https://example.com/ridgeback.jpg", Categoria = "Perros guardianes" },
        new Lista { Nombre = "Samoyedo", Peso = "25 kg", Tamano = "Mediano", Edad = "12 años", Descripcion = "Blanco y sonriente.", ImagenUrl = "https://example.com/samoyed.jpg", Categoria = "Perros familiares" },
        new Lista { Nombre = "Setter Irlandés", Peso = "32 kg", Tamano = "Grande", Edad = "12 años", Descripcion = "Pelirrojo y elegante.", ImagenUrl = "https://example.com/irishsetter.jpg", Categoria = "Perros familiares" },
        new Lista { Nombre = "Spaniel Tibetano", Peso = "5 kg", Tamano = "Pequeño", Edad = "14 años", Descripcion = "Pequeño y alerta.", ImagenUrl = "https://example.com/tibetanspaniel.jpg", Categoria = "Perros pequeños" },
        new Lista { Nombre = "Spitz Japonés", Peso = "10 kg", Tamano = "Pequeño", Edad = "14 años", Descripcion = "Blanco y esponjoso.", ImagenUrl = "https://example.com/japanesespitz.jpg", Categoria = "Perros para apartamento" },
        new Lista { Nombre = "Staffordshire Bull Terrier", Peso = "17 kg", Tamano = "Mediano", Edad = "12 años", Descripcion = "Musculoso y afectuoso.", ImagenUrl = "https://example.com/staffy.jpg", Categoria = "Perros familiares" },
        new Lista { Nombre = "Teckel", Peso = "9 kg", Tamano = "Pequeño", Edad = "14 años", Descripcion = "Salchicha de patas cortas.", ImagenUrl = "https://example.com/dachshund.jpg", Categoria = "Perros pequeños" },
        new Lista { Nombre = "Vizsla", Peso = "25 kg", Tamano = "Mediano", Edad = "12 años", Descripcion = "Húngaro de color dorado.", ImagenUrl = "https://example.com/vizsla.jpg", Categoria = "Perros familiares" },
        new Lista { Nombre = "Xoloitzcuintle", Peso = "14 kg", Tamano = "Mediano", Edad = "13 años", Descripcion = "Perro azteca sin pelo.", ImagenUrl = "https://example.com/xolo.jpg", Categoria = "Perros raros" },
        new Lista { Nombre = "Appenzeller", Peso = "25 kg", Tamano = "Mediano", Edad = "12 años", Descripcion = "Pastor suizo versátil.", ImagenUrl = "https://example.com/appenzeller.jpg", Categoria = "Perros familiares" },
        new Lista { Nombre = "Barbet", Peso = "20 kg", Tamano = "Mediano", Edad = "13 años", Descripcion = "De pelo rizado y acuático.", ImagenUrl = "https://example.com/barbet.jpg", Categoria = "Perros familiares" },
        new Lista { Nombre = "Cirneco del Etna", Peso = "12 kg", Tamano = "Mediano", Edad = "14 años", Descripcion = "Lebrel siciliano.", ImagenUrl = "https://example.com/cirneco.jpg", Categoria = "Perros raros" },
        new Lista { Nombre = "Drever", Peso = "15 kg", Tamano = "Pequeño", Edad = "12 años", Descripcion = "Cazador sueco.", ImagenUrl = "https://example.com/drever.jpg", Categoria = "Perros pequeños" },
        new Lista { Nombre = "Eurasier", Peso = "23 kg", Tamano = "Mediano", Edad = "13 años", Descripcion = "Compañero alemán equilibrado.", ImagenUrl = "https://example.com/eurasier.jpg", Categoria = "Perros familiares" },
        new Lista { Nombre = "Fila Brasileiro", Peso = "50 kg", Tamano = "Grande", Edad = "10 años", Descripcion = "Moloso brasileño protector.", ImagenUrl = "https://example.com/fila.jpg", Categoria = "Perros guardianes" },
        new Lista { Nombre = "Glen of Imaal Terrier", Peso = "16 kg", Tamano = "Pequeño", Edad = "12 años", Descripcion = "Terrier irlandés de patas cortas.", ImagenUrl = "https://example.com/glen.jpg", Categoria = "Perros pequeños" },
        new Lista { Nombre = "Hovawart", Peso = "40 kg", Tamano = "Grande", Edad = "12 años", Descripcion = "Guardián alemán versátil.", ImagenUrl = "https://example.com/hovawart.jpg", Categoria = "Perros guardianes" },
        new Lista { Nombre = "Jindo Coreano", Peso = "20 kg", Tamano = "Mediano", Edad = "13 años", Descripcion = "Leal y reservado.", ImagenUrl = "https://example.com/jindo.jpg", Categoria = "Perros guardianes" },
        new Lista { Nombre = "Kai Ken", Peso = "18 kg", Tamano = "Mediano", Edad = "14 años", Descripcion = "Tigre japonés.", ImagenUrl = "https://example.com/kai.jpg", Categoria = "Perros raros" },
        new Lista { Nombre = "Lagotto Romagnolo", Peso = "16 kg", Tamano = "Mediano", Edad = "15 años", Descripcion = "Buscador de trufas italiano.", ImagenUrl = "https://example.com/lagotto.jpg", Categoria = "Perros familiares" }
            
        };

        return View(perros);
    }
    }
