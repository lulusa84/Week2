using System;

namespace Week2.ComplexNumber
{
    public enum Format
    {
        Algebrico,
        Parentesi
    }
    public class NumeroComplesso
    {
        //a + ib 
        public double RealN { get; set; }

        public double ImagPart { get; set; }

        public static NumeroComplesso NeutralElAdd {
            get
            {
                return new NumeroComplesso()
                {
                    RealN = 0,
                    ImagPart = 0
                };
            }
        }

        public static NumeroComplesso NeutralElProd
        {
            get
            {
                return new NumeroComplesso()
                {
                    RealN = 1,
                    ImagPart = 0
                };
            }
        }


        public NumeroComplesso Coniugato
        {
            get
            {
                return new NumeroComplesso()
                {
                    RealN = this.RealN,
                    ImagPart = ImagPart < 0 ? +this.ImagPart : -this.ImagPart
                };
            }
        }

        public double Modulo
        {
            get => Math.Sqrt(Math.Pow(RealN, 2) + Math.Pow(ImagPart, 2));
        }

        public NumeroComplesso Somma(NumeroComplesso Nc1, NumeroComplesso Nc2)
        {
            NumeroComplesso Risultato = new NumeroComplesso()
            {
                RealN = (Nc1.RealN) + (Nc2.RealN),

                ImagPart = (Nc1.ImagPart + Nc2.RealN)

            };
            return Risultato;
        }

        public NumeroComplesso Differenza(NumeroComplesso Nc1, NumeroComplesso Nc2)
        {
            NumeroComplesso Risultato = new NumeroComplesso()
            {
                RealN = Nc2.RealN > 0 ? (Nc1.RealN) - (Nc2.RealN) : (Nc1.RealN) + (Nc2.RealN),

                ImagPart = Nc2.ImagPart > 0 ? (Nc1.ImagPart) - (Nc2.ImagPart) : (Nc1.ImagPart) + (Nc2.ImagPart)

            };
            return Risultato;
        }

        public NumeroComplesso Prodotto(NumeroComplesso Nc1, NumeroComplesso Nc2)
        {
            NumeroComplesso Risultato = new NumeroComplesso()
            {
                RealN = (Nc1.RealN) * (Nc2.RealN) - (Nc1.ImagPart * Nc2.ImagPart),

                ImagPart = (Nc1.RealN) * (Nc2.ImagPart) + (Nc1.ImagPart * Nc2.RealN)

            };
            return Risultato;
        }


        public NumeroComplesso Divisione(NumeroComplesso Nc1, NumeroComplesso Nc2)
        {

            NumeroComplesso p = Nc1.Prodotto(Nc1, Nc2.Coniugato);

            double denom = Math.Pow(Nc2.RealN, 2) + Math.Pow(Nc2.ImagPart, 2);
            if (Nc2.RealN == 0 || Nc2.ImagPart == 0)
            {
               // throw new DivideByZeroException();
                throw new NumeroComplessoException("Spiacente, la tua operazione non va a buon fine")
                {
                    PrimoOperatore = this,
                    SecondoOperatore = this
                };
            }
            else {
                NumeroComplesso risultato = new NumeroComplesso()
                {
                    RealN = p.RealN / Math.Pow(Nc2.RealN, 2) + Math.Pow(Nc2.ImagPart, 2),
                    ImagPart = p.ImagPart / Math.Pow(Nc2.RealN, 2) + Math.Pow(Nc2.ImagPart, 2)
                };

                return risultato;
            }

        }

        #region  OPERAZIONI FRA NUMERI COMPLESSI E  UN DOUBLE
        public NumeroComplesso Somma(Double d2)
        {
            NumeroComplesso Risultato = new NumeroComplesso()
            {
                RealN = (this.RealN) + (d2),

                ImagPart = (this.ImagPart + d2)

            };
            return Risultato;
        }

        public NumeroComplesso DifferenzaNcDouble(Double d2)
        {
            NumeroComplesso Risultato = new NumeroComplesso()
            {
                RealN = d2 > 0 ? (this.RealN) - (d2) : (this.RealN) + (d2),

                ImagPart = this.ImagPart

            };
            return Risultato;
        }

        public NumeroComplesso Prodotto(Double d2)
        {
            NumeroComplesso Risultato = new NumeroComplesso()
            {
                RealN = (this.RealN) * (d2) - (this.ImagPart * 0),

                ImagPart = (this.RealN) * (0) + (this.ImagPart * d2)

            };
            return Risultato;
        }


        public NumeroComplesso DivisioneD(Double d2)
        {
            double denom = Math.Pow(d2, 2) + Math.Pow(0, 2);
            if (d2 == 0)
            {
                //throw new DivideByZeroException();

                throw new NumeroComplessoException("Spiacente, la tua operazione non va a buon fine")
                {
                    PrimoOperatore = this,
                    SecondoOperatore = this
                };
            }
            else
            {
                NumeroComplesso risultato = new NumeroComplesso()
                {
                    RealN = (this.RealN * d2) + (this.ImagPart * 0) / Math.Pow(d2, 2) + Math.Pow(0, 2),
                    ImagPart = (this.ImagPart * d2) - (this.RealN * 0) / Math.Pow(d2, 2) + Math.Pow(0, 2)
                };

                return risultato;
            }

        }

        public static NumeroComplesso CreateComplex(Double RealN, Double ImagPart)
        {
            /* NumeroComplesso Nc = new NumeroComplesso
             {
                 RealN = RealN,
                 ImagPart = ImagPart
             };

             return Nc;  */

            return new NumeroComplesso

            {
                RealN = RealN,
                ImagPart = ImagPart
            };

        }


        #endregion
        public override string ToString()
        {
            return $"Reale: {RealN} - Immaginaria: {ImagPart}";
        }

        #region  operatori e comparatori

        public static NumeroComplesso operator +(NumeroComplesso Nc1, NumeroComplesso Nc2)
        {
            return Nc1.Somma(Nc1, Nc2);
        }

         public static NumeroComplesso operator -(NumeroComplesso Nc1)
        {
            return new NumeroComplesso()
            {
                RealN = -Nc1.RealN,
                ImagPart = -Nc1.ImagPart
            };
       } 


        public static NumeroComplesso operator -(NumeroComplesso Nc1, NumeroComplesso Nc2)
        {
            return Nc1.Differenza(Nc1, Nc2);
        }
        public static NumeroComplesso operator *(NumeroComplesso Nc1, NumeroComplesso Nc2)
        {
            return Nc1.Prodotto(Nc1, Nc2);
        }

        public static NumeroComplesso operator /(NumeroComplesso Nc1, NumeroComplesso Nc2)
        {
            return Nc1.Divisione(Nc1, Nc2);
        }

        public static explicit operator double(NumeroComplesso nc)
        {
            if (nc.ImagPart == 0)
            {
                double ncConvertito = (nc.Modulo);
                return ncConvertito;
                //return modulo
            }
            return 0;
        }

        public static implicit operator NumeroComplesso(double d)
        {
            return new NumeroComplesso

            {
                RealN = d,
                ImagPart = 0
            };

        }
        public static bool operator ==(NumeroComplesso Nc1, NumeroComplesso Nc2)
        {
            //Verifico  che i due oggetti non siano null
            if (object.ReferenceEquals(Nc1, null)) // a) punta a null
            {
                if (object.ReferenceEquals(Nc2, null))
                {
                    return true;
                }
                return false;
            }

            return Nc1.Equals(Nc2);
        }

        public static bool operator !=(NumeroComplesso Nc1, NumeroComplesso Nc2)
        {
            return !(Nc1 == Nc2);
        }


        public override bool Equals(object obj)
        {
            //Verifico  che i due oggetti non siano null
            if (object.ReferenceEquals(obj, null)) // a) punta a null
            {
               
                    return false;
                }

                else
                {
                    NumeroComplesso Nc2 = (NumeroComplesso)obj;
                    if (RealN == Nc2.RealN && ImagPart == Nc2.ImagPart)
                    {

                        return true;
                    }
                    else
                    {

                        return false;

                    }
                }

            }
        

            #endregion

            public string ToString(Format format)
            {
                switch (format)
                {
                    default:
                        return this.ToString();
                    // break;
                    case Format.Algebrico:
                        return $"{RealN} { (ImagPart < 0 ? "-" : "+") } i {Math.Abs(ImagPart)}";
                    // break;
                    case Format.Parentesi:
                        return $"({RealN}, {ImagPart})";
                        // break;

                }
            }

        }
    }


