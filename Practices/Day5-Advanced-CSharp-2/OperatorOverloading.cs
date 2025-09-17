/* digunakan untuk redefine */
public struct Note
{
    public int value;
    public Note(int semitonesFromA) => value = semitonesFromA;

    public static Note operator +(Note x, int semitones)
    {
        return new Note(x.value + semitones);
    }
}