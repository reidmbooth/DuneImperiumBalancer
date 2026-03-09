namespace DuneImperiumSpacesGenerator
{
    public interface IBoard
    {
        List<Space> Spaces { get; }
        //allows the return of the generated spaces
        void SetSpaceRandomizationConstraints(SpaceRandomizationConstraints constraints);
        //allows the user to pass a set of constraints on generation
        bool TryRandomizeSpaces();
        //try to actually generate spaces, returning false if the constraints are impossible to satisfy

    }

    public class DuneImperiumBoard : IBoard
    {
        public List<Space> Spaces { get; set; }
        private SpaceRandomizationConstraints Constraints { get; set; }

        public DuneImperiumBoard()
        {
            Spaces = new List<Space>();
            Constraints = new SpaceRandomizationConstraints();
        }

        public void SetSpaceRandomizationConstraints(SpaceRandomizationConstraints _constraints)
        {
            Constraints = _constraints;
        }

        public bool TryRandomizeSpaces()
        {
            return true;
        }
    }
}
