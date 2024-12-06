import { useQuery } from "@tanstack/react-query";
import { useEffect } from "react";

interface IFighter {
  id: number;
  name: string;
}

function FightersComponent() {
  const { isPending, data } = useQuery<IFighter[]>({
    queryKey: ["fighters"],
    queryFn: () =>
      fetch("http://localhost:5242/fighters").then((res) => res.json()),
  });

  return (
    <div className="h-full">
      {isPending || data == null ? (
        <div>Loading...</div>
      ) : (
        <FightersList fighters={data} />
      )}
    </div>
  );
}

function FightersList(props: { fighters: IFighter[] }) {
  return (
    <div className="flex flex-col gap-1 h-full">
      <ul className="bg-slate-400 rounded-lg p-1 h-full">
        {props.fighters.map((fighter: IFighter) => (
          <FightersListItem fighter={fighter} />
        ))}
      </ul>
    </div>
  );
}

function FightersListItem(props: { fighter: IFighter }) {
  return (
    <li className="hover:bg-slate-500 active:bg-slate-600 select-none rounded-lg cursor-pointer">
      <span className="m-1">{props.fighter.name}</span>
    </li>
  );
}

export default FightersComponent;
