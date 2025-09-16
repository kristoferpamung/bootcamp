/* digunakan untuk redefine */
public struct Note
{
    int value;
    public Note(int semitonesFromA) => value = semitonesFromA;

    public static Note operator +(Note x, int semitones)
    {
        return new Note(x.value + semitones);
    }
}