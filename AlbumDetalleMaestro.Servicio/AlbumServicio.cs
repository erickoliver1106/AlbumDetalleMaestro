﻿using AlbumDetalleMaestro.Datos;
using AlbumDetalleMaestro.Modelo;
using System.Transactions;

namespace AlbumDetalleMaestro.Servicio
{
    public class AlbumServicio : IAlbumServicio
    {
        private IAlbumRepositorio _repositorio;
        private ICancionServicio _cancionServicio;

        public AlbumServicio()
        {
            _repositorio = new AlbumRepositorio();
            _cancionServicio = new CancionServicio();
        }

        public bool EliminarAlbum(Album album)
        {
            throw new NotImplementedException();
        }

        public bool GuardarAlbum(Album album)
        {
            bool ok = false;
            using (TransactionScope ts = new TransactionScope())
            {
                if (album.Id == Guid.Empty)
                {
                    album.Id = Guid.NewGuid();
                    ok = _repositorio.InsertarAlbum(album);

                    if (ok)
                    {
                        foreach (Cancion cancion in album.Canciones)
                        {
                            cancion.AlbumId = album.Id;
                            _cancionServicio.GuardarCancion(cancion);
                        }
                    }
                    ts.Complete();
                }
                return ok;
            }
        }

        public List<Album> ObtenerAlbums()
        {
            throw new NotImplementedException();
        }
    }
}
