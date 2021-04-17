class Node{
    constructor(data){
        this.data = data;
        this.next = null;
    }
}

function Reverse(curr)
{
    var prev = null;
    var next = null;

    while (curr != null)
    {
        next = curr.next;

        curr.next = prev;
        prev = curr;

        if (next == null)
            return curr;

        curr = next;       
    }

    return curr;
}