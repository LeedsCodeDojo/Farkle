import org.junit.jupiter.api.Assertions.assertEquals
import org.junit.jupiter.api.Nested
import org.junit.jupiter.api.Test

class FarkleTest {

    private fun testRoll(expectedScore: Int, roll: List<Int>) =
        assertEquals(expectedScore, Farkle.roll(*roll.toTypedArray()))

    @Nested
    inner class `when rolling 5 dice` {
        @Test fun `rolling a zero scoring roll`() =
            testRoll(0, listOf(2, 3, 4, 6, 2))

        @Test fun `rolling one five scores 50`() =
            testRoll(50, listOf(2, 3, 4, 5, 2))

        @Test fun `rolling three fives scores 500`() =
            testRoll(500, listOf(5, 5, 5, 2, 3))

        @Test fun `single one scores 100`() =
            testRoll(100, listOf(1, 2, 3, 4, 6))

        @Test fun `rolling three ones scores 1000`() =
            testRoll(1000, listOf(1, 1, 1, 2, 3))

        @Test fun `rolling four ones scores 1100`() =
            testRoll(1100, listOf(1, 1, 1, 1, 3))

        @Test fun `rolling four ones and a five scores 1150`() =
            testRoll(1150, listOf(1, 1, 1, 1, 5))

        @Test fun `rolling three twos scores 200`() =
            testRoll(200, listOf(2, 2, 2, 4, 6))

        @Test fun `rolling three threes scores 300`() =
            testRoll(300, listOf(3, 3, 3, 2, 4))

        @Test fun `rolling three fours scores 400`() =
            testRoll(400, listOf(4, 4, 4, 2, 3))

        @Test fun `rolling three sixes scores 600`() =
            testRoll(600, listOf(6, 6, 6, 2, 3))

        @Test fun `rolling three threes and one five scores 350`() =
            testRoll(350, listOf(3, 4, 5, 3, 3))
    }

    @Nested inner class `when rolling 6 dice` {

        @Test fun `rolling four ones scores 2000`() =
            testRoll(2000, listOf(1, 1, 1, 1, 3, 3))

        @Test fun `rolling five ones scores 4000`() =
            testRoll(4000, listOf(1, 1, 1, 1, 1, 3))

        @Test fun `rolling six ones scores 8000`() =
            testRoll(8000, listOf(1, 1, 1, 1, 1, 1))
    }
}