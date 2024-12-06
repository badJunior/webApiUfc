import { useQuery } from "@tanstack/react-query";

interface IFighter {
  id: number;
  name: string;
}

function FightersList() {
  const { isPending, data } = useQuery<IFighter[]>({
    queryKey: ["fighters"],
    queryFn: () =>
      fetch("http://localhost:5242/fighters").then((res) => res.json()),
  });

  return (
    <div>
      {isPending ? (
        <div>Loading...</div>
      ) : (
        <div className="flex flex-col gap-1 h-full">
          <ul className="bg-slate-400 rounded-lg p-1 h-full">
            {data?.map((fighter: IFighter) => (
              <li>{fighter.name}</li>
            ))}
          </ul>
        </div>
      )}
    </div>
  );
}

export default FightersList;
