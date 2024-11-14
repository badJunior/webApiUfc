import { useMutation, useQueryClient } from "@tanstack/react-query";
import FightersList from "./FightersList";
import WinnersList from "./WinnersList";

function UfcList() {
  const queryClient = useQueryClient();
  const mutation = useMutation({
    mutationFn: () => fetch("http://localhost:5242/cards", {
      method: "POST"
    }).then((res) => res.json()),
    onSuccess: () => {
      // Invalidate and refetch
      queryClient.invalidateQueries({ queryKey: ["winners"], exact: false })
    }});
  return (
    <div className="flex size-full justify-center bg-slate-500">
      <div className="flex flex-col gap-2">
        <h1 className="text-5xl font-bold text-center underline">
          Ufc
        </h1>
        <div className="flex flex-col w-[300px] gap-1">
          <FightersList />
          <WinnersList />
          <button onClick={() => mutation.mutate()} className="bg-slate-600 rounded-lg hover:bg-slate-800 active:bg-slate-900 h-9">Make card</button>
        </div>
      </div>
    </div>
  );
}

export default UfcList;
