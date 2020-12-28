using System;

namespace dotnetDelegate
{
    class Car{
        public delegate void TooFast();
        public delegate void TooSlow();

        private TooFast _toofast;

        private TooSlow _tooslow;
        int _speed = 0;

        public void Start(){
            _speed = 10;
        }
        public void Accelerate(){
            _speed+=50;
            if(_speed>100){
                if(_toofast!=null){
                    _toofast();
                }
            }
        }
        public void Slowing(){
            _speed-=50;
            if(_speed<=0){
                if(_tooslow!=null){
                    _tooslow();
                }
            }
        }
        public void Stop(){
            _speed = 0;
        }
        public void RegistetTooFast(TooFast toofast){
            _toofast = toofast;
        }
        public void RegistetTooSlow(TooSlow tooslow){
            _tooslow = tooslow;
        }
    }
}