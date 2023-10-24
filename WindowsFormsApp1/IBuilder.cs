using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public interface IBuilder
    {
        void BuildPartA(string name);

        void BuildPartB(string name);

        void BuildPartC(string name);
        void BuildPartD(string name);

        void BuildPartE(string name);

        void BuildPartF(string name);
        Computer GetProduct();
    }

    public class GamingComputerBuilder : IBuilder
    {
        private Computer _computer = new Computer();

        public GamingComputerBuilder()
        {
            this.Reset();
            this._computer.addname("Игровая сборка");
        }

        public void Reset()
        {
            this._computer = new Computer();
        }

        public void BuildPartA(string name)
        {
            this._computer.addProcessor(name);
        }

        public void BuildPartB(string name)
        {
            this._computer.addRAM(name);
        }

        public void BuildPartC(string name)
        {
            this._computer.addharddrive(name);
        }

        public void BuildPartD(string name)
        {
            this._computer.addmotherbourd(name);
        }

        public void BuildPartE(string name)
        {
            this._computer.addpowerunit(name);
        }

        public void BuildPartF(string name)
        {
            this._computer.addvideocard(name);
        }

        public Computer GetProduct()
        {
            Computer result = this._computer;
            return result;
        }
    }
    public class WorkstationComputerBuilder : IBuilder
    {
        private Computer _computer = new Computer();

        public WorkstationComputerBuilder()
        {
            this.Reset();
            this._computer.addname("Рабочая сборка");
        }

        public void Reset()
        {
            this._computer = new Computer();
        }

        public void BuildPartA(string name)
        {
            this._computer.addProcessor(name);
        }

        public void BuildPartB(string name)
        {
            this._computer.addRAM(name);
        }

        public void BuildPartC(string name)
        {
            this._computer.addharddrive(name);
        }

        public void BuildPartD(string name)
        {
            this._computer.addmotherbourd(name);
        }

        public void BuildPartE(string name)
        {
            this._computer.addpowerunit(name);
        }

        public void BuildPartF(string name)
        {
            this._computer.addvideocard(name);
        }

        public Computer GetProduct()
        {
            Computer result = this._computer;
            return result;
        }
    }
    public class MinComputerBuilder : IBuilder
    {
        private Computer _computer = new Computer();

        public MinComputerBuilder()
        {
            this.Reset();
            this._computer.addname("Минимальная сборка");
        }

        public void Reset()
        {
            this._computer = new Computer();
        }

        public void BuildPartA(string name)
        {
            this._computer.addProcessor(name);
        }

        public void BuildPartB(string name)
        {
            this._computer.addRAM(name);
        }

        public void BuildPartC(string name)
        {
            this._computer.addharddrive(name);
        }

        public void BuildPartD(string name)
        {
            this._computer.addmotherbourd(name);
        }

        public void BuildPartE(string name)
        {
            this._computer.addpowerunit(name);
        }

        public void BuildPartF(string name)
        {
            this._computer.addvideocard(name);
        }

        public Computer GetProduct()
        {
            Computer result = this._computer;
            return result;
        }
    }
    public class Computer
    {
        private string name = null;
        private string processor = null;
        private string RAM = null;
        private string harddrive = null;
        private string motherboard = null;
        private string powerunit = null;
        private string videocard = null;

        public void addname(string part)
        {
            this.name = part;
        }
        public void addProcessor(string part)
        {
            this.processor=part;
        }
        public void addRAM(string part)
        {
            this.RAM=part;
        }
        public void addharddrive(string part)
        {
            this.harddrive = part;
        }
        public void addmotherbourd(string part)
        {
            this.motherboard=part;
        }
        public void addpowerunit(string part)
        {
            this.powerunit=part;
        }
        public void addvideocard(string part)
        {
            this.videocard=part;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (name != null)
                sb.Append(name + ":\n");
            if (processor != null)
                sb.Append("Тактовая частота: " + processor + "ГГц" + " \n");
            if (RAM != null)
                sb.Append("Оперативная память: " + RAM + "Гб " + " \n");
            if (harddrive != null)
                sb.Append("Объём жёсткого диска: " + harddrive + "Гб" + " \n");
            if (motherboard != null)
                sb.Append("Сокет: " + motherboard + " \n");
            if (powerunit != null)
                sb.Append("Мощность блока питания: " + powerunit + "W" + " \n");
            if (videocard != null)
                sb.Append("Объём видеопамяти: " + videocard + "Гб" + " \n");
            return sb.ToString();
        }
    }
    public class Director
    {
        private IBuilder _computerbuilder;

        public IBuilder Builder
        {
            set { _computerbuilder = value; }
        }

        public void MinComputerBuilder(string A, string B, string C, string D, string E, string F)
        {
            this._computerbuilder.BuildPartA(A);
            this._computerbuilder.BuildPartB(B);
            this._computerbuilder.BuildPartC(C);
            this._computerbuilder.BuildPartD(D);
            this._computerbuilder.BuildPartE(E);
            this._computerbuilder.BuildPartF(F);
        }
        public void WorkstationComputerBuilder(string A, string B, string C, string D, string E, string F)
        {
            this._computerbuilder.BuildPartA(A);
            this._computerbuilder.BuildPartB(B);
            this._computerbuilder.BuildPartC(C);
            this._computerbuilder.BuildPartE(E);
            this._computerbuilder.BuildPartF(F);
        }
        public void GamimgComputerBuilder(string A, string B, string C, string D, string E, string F)
        {
            this._computerbuilder.BuildPartA(A);
            this._computerbuilder.BuildPartB(B);
            this._computerbuilder.BuildPartC(C);
            this._computerbuilder.BuildPartF(F);
        }
    }
}
