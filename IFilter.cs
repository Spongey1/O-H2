namespace O_H2
{
    // Handles the Filter State
    public interface IFilter
    {
        bool FilterOn { get; set; }

        bool isUsed { get; set; }
        void Renew();
    }
}