using MinotaurLabyrinth;

namespace MinotaurLabyrinthTest
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void PitRoomTest()
        {
         Pit pitRoom = new Pit();
         Hero hero = new Hero();
        Map map = new Map(1,1);

        pitRoom.Activate(hero, map);

        if (hero.IsAlive) {
             Assert.AreEqual(pitRoom.IsActive, false);
        }
    }
}
