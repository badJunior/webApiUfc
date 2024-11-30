import { useMutation, useQueryClient } from "@tanstack/react-query";
import FightersList from "./FightersList";
import WinnersList from "./WinnersList";
import BestWinnersList from "./BestWinnersList";  

function UfcList() {
  const queryClient = useQueryClient();
  const mutation = useMutation({
    mutationFn: () =>
      fetch("http://localhost:5242/cards", {
        method: "POST",
      }
    ),
    onSuccess: () => {
      // Invalidate and refetch
      queryClient.invalidateQueries({ queryKey: ["winners"], exact: false });
      queryClient.invalidateQueries({ queryKey: ["bestWinners"], exact: false });
    

    },


  });
  
  return (
    <div className="flex size-full justify-center bg-slate-500">
      <div className="flex flex-col   gap-2  w-[30%] ">
        <h1 className="text-5xl font-bold text-center underline">UFC</h1>
        <div className="grid grid-rows-[1fr,auro,1fr] gap-1  h-full w-full  overflow-hidden">
          <FightersList />
          <button
            onClick={() => mutation.mutate()}
            className="bg-slate-600 rounded-lg hover:bg-slate-800 active:bg-slate-900 h-9"

          >
            Make card
          </button>
          <WinnersList />
          <BestWinnersList/>
          
        </div>
      </div>
    </div>
  );
}

export default UfcList;
