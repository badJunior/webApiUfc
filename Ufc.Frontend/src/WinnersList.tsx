import { useQuery } from "@tanstack/react-query";
import { useEffect } from "react";

interface IWinner {
  fighterName: string;
  numberCard: number;
  quantityWins: number;
}

function WinnersList() {
  const { isPending, data } = useQuery<IWinner[]>({
    queryKey: ["winners"],
    queryFn: () =>
      fetch("http://localhost:5242/winners").then((res) => res.json()),
  });

  return (
    <div className="h-full bg-slate-400 overflow-hidden rounded-lg p-1">
      {isPending ? (
        <div>Loading...</div>
      ) : (
        <div className="size-full overflow-y-auto">
          <table className="grid h-auto gap-1">
            {data?.map((winner) => (
              <WinnersListItem winner={winner} />
            ))}
          </table>
        </div>
      )}
    </div>
  );
}

function WinnersListItem(props: { winner: IWinner }) {
  return (
    <tr className="flex gap-2 hover:bg-slate-500">
      <span className="shrink">{props.winner.numberCard}</span>
      <span className="grow">{props.winner.fighterName}</span>
      <span className="shrink">{props.winner.quantityWins}</span>
    </tr>
  );
}

export default WinnersList;
