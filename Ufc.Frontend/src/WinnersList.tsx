import { useQuery } from "@tanstack/react-query";

interface IWinner{  
        fighterName: string,
        numberCard: number,
        quantityWins: number
}

function WinnersList() {
  const { isPending, data } = useQuery<IWinner[]>({
    queryKey: ["winners"],
    queryFn: () =>
      fetch("http://localhost:5242/winners").then((res) => res.json()),
  });

  return (
    <div>
      {isPending ? (
        <div>Loading...</div>
      ) : (
          <div className="bg-slate-400 rounded-lg p-1 grid grid-cols-[auto,1fr,auto] gap-1">
            {data?.map((winner) => (
              <>
              <span>{winner.numberCard}</span>
              <span>{winner.fighterName}</span>
              <span>{winner.quantityWins}</span>
              </>
            ))}
          </div>
      )}
    </div>
  );
}

export default WinnersList;
