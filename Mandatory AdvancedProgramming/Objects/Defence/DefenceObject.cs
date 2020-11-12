using System;

namespace Mandatory_AdvancedProgramming.Objects.Defence
{
    public class DefenceObject
    {
        private string _name;
        private Position _position;
        private int _mindefence;
        private int _maxdefence;
        private bool _enchanced;

        public DefenceObject(string name, Position position,  int mindefence, int maxdefence, bool enchanced) 
        {
            _name = name;
            _position = position;
            _mindefence = mindefence;
            _maxdefence = maxdefence;
            _enchanced = enchanced;
        }

        public string Name { get; set; }
        public Position Position { get; set; }
        public int MinDefence { get; set; }
        public int MaxDefence { get; set; }
        public bool Enchanced { get; set; }
    }
}