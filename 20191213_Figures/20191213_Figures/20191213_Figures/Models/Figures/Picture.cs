using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20191213_Figures.Models.Figures
{
    class Picture
    {
        private Figure[] _pictures = new Figure[10];
        private int _sizePictures;

        public int Size { get => _sizePictures; }

        public void AddFigure(Figure figure)
        {
            if (_sizePictures + 1 == _pictures.Length)
            {
                Array.Resize(ref _pictures, 10);
            }

            _pictures[_sizePictures] = figure;

            _sizePictures++;
        }

        public void Show()
        {
            for (int i = 0; i < _pictures.Length; i++)
            {
                if (_pictures[i] == default)
                {
                    continue;
                }

                _pictures[i].Show();
            }
        }
        public void Move()
        {
            for (int i = 0; i < _pictures.Length; i++)
            {
                if (_pictures[i] == default)
                {
                    continue;
                }

                Coordinate NewPosition = new Coordinate(_pictures[i].CenterPosition.X + 25, _pictures[i].CenterPosition.Y + 5);

                _pictures[i].Move(NewPosition);
            }
        }
    }
}
