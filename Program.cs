﻿using ScreenSound;

Musica musica1 = new Musica();
musica1.Nome = "Roxane";
musica1.Artista = "The Police";
musica1.Duracao = 273;
musica1.Disponivel = true;

Musica musica2 = new Musica();
musica2.Nome = "Vertigo";
musica2.Artista = "US";
musica2.Duracao = 967;
musica2.Disponivel = false;

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();