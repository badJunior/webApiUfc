import { useMutation, useQueryClient } from "@tanstack/react-query";
import FightersComponent from "./FightersList";
import WinnersList from "./WinnersList";
import BestWinnersList from "./BestWinnersList";

function UfcList() {
  return (
    <div className="flex size-full justify-center bg-slate-500 h-full p-1 overflow-hidden">
      <div className="grid grid-rows-[auto,1fr] gap-2 w-[30%] min-w-[400px] h-full overflow-hidden">
        <h1 className="text-5xl font-bold text-center underline">UFC</h1>

        <div className="grid grid-rows-[auto,auto,1fr] h-full gap-2 w-full overflow-hidden">
          <div className="flex justify-center">
            <div className="flex w-[50%]">
              <BestWinnersList />
            </div>
          </div>
          <MakeCardButton />
          <div className="grid grid-cols-2 gap-2 h-full overflow-hidden">
            <FightersComponent />
            <WinnersList />
          </div>
        </div>
      </div>
    </div>
  );
}

type ButtonProps = {
  action: () => void;
  caption: string;
};

const MakeCardButton = function () {
  const queryClient = useQueryClient();
  const mutation = useMutation({
    mutationFn: () =>
      fetch("http://localhost:5242/cards", {
        method: "POST",
      }),
    onSuccess: () => {
      // Invalidate and refetch
      queryClient.invalidateQueries({ queryKey: ["winners"], exact: false });
      queryClient.invalidateQueries({
        queryKey: ["bestWinners"],
        exact: false,
      });
    },
  });

  return <Button action={() => mutation.mutate()} caption="Make Card" />;
};

const Button = function (props: ButtonProps) {
  return (
    <button
      onClick={() => props.action()}
      className="bg-slate-600 rounded-lg hover:bg-slate-800 active:bg-slate-900 h-9"
    >
      {props.caption}
    </button>
  );
};

export default UfcList;
