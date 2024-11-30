import { useQuery } from "@tanstack/react-query";

interface IBestWinner {
  fighterName: string;
  quantityWins: number;
}

function BestWinnersList() {
  const { isPending, data } = useQuery<IBestWinner[]>({
    queryKey: ["bestWinners"],
    queryFn: () =>
      fetch("http://localhost:5242/bestWinners").then((res) => res.json()),
  });

  return (
    <div className="h-full bg-slate-400 overflow-hidden rounded-lg p-1">
      {isPending ? (
        <div>Loading...</div>
      ) : (
        <div className="grid h-full overflow-auto grid-cols-[1fr,auto] gap-1">
          {data?.map((bestWinner) => (
            <>
              <span>{bestWinner.fighterName}</span>
              <span>{bestWinner.quantityWins}</span>
            </>
          ))}
        </div>
      )}
    </div>
  );
}

export default BestWinnersList;
