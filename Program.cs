public class Solution
{

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode current1 = l1;
        ListNode current2 = l2;

        List<int> numsListInNode1 = new List<int>();
        List<int> invertNumsListInNode1 = new List<int>();
        while (current1 != null)
        {
            numsListInNode1.Add(current1.val);
            current1 = current1.next;
        }

        int lastIndexofnumsListNode1 =  numsListInNode1.Count -1; // Count - 1 = last index
        for (int i = lastIndexofnumsListNode1; i > -1; i--)
        {
            invertNumsListInNode1.Add(numsListInNode1[i]); 
        }
        
        Console.WriteLine(string.Join(", ", numsListInNode1));
        Console.WriteLine(string.Join(", ", invertNumsListInNode1));
        return null;

    }
    public static void AfficherListe(ListNode head)
    {
        ListNode current = head;
        while (current != null)
        {
            Console.Write(current.val + " -> ");
            current = current.next;
        }
        Console.WriteLine("null");
    }

    static void Main(string[]args)
    {
        Solution s = new Solution();

        ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
        ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4)));

        //AfficherListe(l1);

        s.AddTwoNumbers(l1, l2);
    }
}
