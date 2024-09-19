using AlbumDetalleMaestro.Modelo;
using AlbumDetalleMaestro.Servicio;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Storage;

namespace AlbumDetalleMaestro.WinForm
{
    public partial class Form1 : Form
    {
        private Album _album;
        private IAlbumServicio _albumServicio;

        public Form1()
        {
            InitializeComponent();
            _album = new Album();
            _albumServicio = new AlbumServicio();
            
        }
        private void AñadirCancion()
        {
            Cancion song = new Cancion();


            song.Nombre = txtSongName.Text;

            try

            {
                song.Minutos = txtMinutes.Text != string.Empty
                    ? int.Parse(txtMinutes.Text)
                    : 0;
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese un numero valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (_album.Canciones == null)
                _album.Canciones = new List<Cancion>();

            _album.Canciones.Add(song);

        }
        private void LimpiarCancion()
        {
            txtSongName.Text = string.Empty;
            txtMinutes.Text = string.Empty;
        }
        private void LimpiarAlbum()
        {
            txtAlbumName.Text = string.Empty;
            txtAuthor.Text = string.Empty;
            txtReleaseDate.Value = DateTime.Now;
        }

        private void GuardarAlbum()
        {
            _album.Nombre = txtAlbumName.Text;
            _album.Autor = txtAuthor.Text;
            _album.FechaLanzamiento = txtReleaseDate.Value;

            _albumServicio.GuardarAlbum2(_album);
        }



        private void btnSongAdd_Click(object sender, EventArgs e)
        {
            AñadirCancion();
            grdSongs.AutoGenerateColumns = false;

            BindingSource bs = new BindingSource();
            bs.DataSource = _album.Canciones;
            grdSongs.DataSource = bs;

            LimpiarCancion();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            GuardarAlbum();
            LimpiarAlbum();
        }

        private void btnSongAdd_Click_1(object sender, EventArgs e)
        {
            AñadirCancion();
            grdSongs.AutoGenerateColumns = false;

            BindingSource bs = new BindingSource();
            bs.DataSource = _album.Canciones;
            grdSongs.DataSource = bs;

            LimpiarCancion();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            GuardarAlbum();
            LimpiarAlbum();
        }
    }
}
